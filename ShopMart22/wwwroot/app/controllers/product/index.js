﻿var productController = function () {

    this.initialize = function () {
        loadCategories();
        loadData();
        registerEvents();
        registerControls();
    }

    function registerEvents() {
        // todo: binding events to controls
        $('#frmMaintainance').validate({
            errorClass: 'red',
            ignore: [],
            lang: 'en',
            rules: {
                txtNameM: { required: true },
                ddlCategoryIdM: { required: true },
                txtPriceM: {
                    required: true,
                    number: true
                }
            }
        });

        $('#ddlShowPage').on('change', function () {
            ShopMart22.configs.pageSize = $(this).val();
            ShopMart22.configs.pageIndex = 1;
            loadData(true);
        });

        $('#btnSearch').on('click', function () {
            loadData();
        });

        $('#txtKeyword').on('keypress', function (e) {
            if (e.which === 13) {
                loadData();
            }
        });

        $("#btnCreate").on('click', function () {
            resetFormMaintainance();
            $.ajax({
                url: "/Admin/ProductCategory/GetAll",
                type: 'GET',
                dataType: 'json',
                async: false,
                success: function (response) {
                    var data = [];
                    $.each(response, function (i, item) {
                        data.push({
                            id: item.Id,
                            text: item.Name,
                            parentId: item.ParentId,
                            sortOrder: item.SortOrder
                        });
                    });
                    var arr = ShopMart22.unflattern(data);
                    $('#ddlCategoryIdM').combotree({
                        data: arr
                    });

                    $('#ddlCategoryIdImportExcel').combotree({
                        data: arr
                    });
                    
                }
            });
            $('#modal-add-edit').modal('show');

        });

        $('#btnSelectImg').on('click', function () {
            $('#fileInputImage').click();
        });

        $("#fileInputImage").on('change', function () {
            var fileUpload = $(this).get(0);
            var files = fileUpload.files;
            var data = new FormData();
            for (var i = 0; i < files.length; i++) {
                data.append(files[i].name, files[i]);
            }
            $.ajax({
                type: "POST",
                url: "/Admin/Upload/UploadImage",
                contentType: false,
                processData: false,
                data: data,
                success: function (path) {
                    $('#txtImage').val(path);
                    ShopMart22.notify('Upload image succesful!', 'success');

                },
                error: function () {
                    ShopMart22.notify('There was error uploading files!', 'error');
                }
            });
        });

        $('body').on('click', '.btn-edit', function (e) {
            e.preventDefault();
            var that = $(this).data('id');
            loadDetails(that);
        });

        $('body').on('click', '.btn-delete', function (e) {
            e.preventDefault();
            var that = $(this).data('id');
            ShopMart22.confirm('Are you sure to delete?', function () {
                $.ajax({
                    type: "POST",
                    url: "/Admin/Product/Delete",
                    data: { id: that },
                    dataType: "json",
                    beforeSend: function () {
                        ShopMart22.startLoading();
                    },
                    success: function (response) {
                        ShopMart22.notify('Delete successful', 'success');
                        resetFormMaintainance();

                        ShopMart22.stopLoading();
                        loadData(true);
                    },
                    error: function (status) {
                        ShopMart22.notify('Has an error in delete progress', 'error');
                        ShopMart22.stopLoading();
                    }
                });
            });
        });

        $('#btnSave').on('click', function (e) {
            saveProduct(e);
        });
    }

    function registerControls() {
        CKEDITOR.replace('txtContent', {});

        //Fix: cannot click on element ck in modal
        //$.fn.modal.Constructor.prototype.enforceFocus = function () {
        //    $(document)
        //        .off('focusin.bs.modal') // guard against infinite focus loop
        //        .on('focusin.bs.modal', $.proxy(function (e) {
        //            if (
        //                this.$element[0] !== e.target && !this.$element.has(e.target).length
        //                // CKEditor compatibility fix start.
        //                && !$(e.target).closest('.cke_dialog, .cke').length
        //                // CKEditor compatibility fix end.
        //            ) {
        //                this.$element.trigger('focus');
        //            }
        //        }, this));
        //};

    }

    function loadDetails(that) {
        $.ajax({
            type: "GET",
            url: "/Admin/Product/GetById",
            data: { id: that },
            dataType: "json",
            beforeSend: function () {
                ShopMart22.startLoading();
            },
            success: function (response) {
                var data = response;
                $('#hidIdM').val(data.Id);
                $('#txtNameM').val(data.Name);
                initTreeDropDownCategory(data.CategoryId);

                $('#txtDescM').val(data.Description);
                $('#txtUnitM').val(data.Unit);

                $('#txtPriceM').val(data.Price);
                $('#txtOriginalPriceM').val(data.OriginalPrice);
                $('#txtPromotionPriceM').val(data.PromotionPrice);

                $('#txtImageM').val(data.ThumbnailImage);

                $('#txtTagM').val(data.Tags);
                $('#txtMetakeywordM').val(data.SeoKeywords);
                $('#txtMetaDescriptionM').val(data.SeoDescription);
                $('#txtSeoPageTitleM').val(data.SeoPageTitle);
                $('#txtSeoAliasM').val(data.SeoAlias);

                CKEDITOR.instances.txtContent.setData(data.Content);
                $('#ckStatusM').prop('checked', data.Status == 1);
                $('#ckHotM').prop('checked', data.HotFlag);
                $('#ckShowHomeM').prop('checked', data.HomeFlag);

                $('#modal-add-edit').modal('show');
                ShopMart22.stopLoading();

            },
            error: function (status) {
                ShopMart22.notify('Có lỗi xảy ra', 'error');
                ShopMart22.stopLoading();
            }
        });
    }

    function saveProduct(e) {
        if ($('#frmMaintainance').valid()) {
            e.preventDefault();
            var id = $('#hidIdM').val();
            var name = $('#txtNameM').val();
            var categoryId = $('#ddlCategoryIdM').combotree('getValue');

            var description = $('#txtDescM').val();
            var unit = $('#txtUnitM').val();

            var price = $('#txtPriceM').val();
            var originalPrice = $('#txtOriginalPriceM').val();
            var promotionPrice = $('#txtPromotionPriceM').val();

            //var image = $('#txtImageM').val();

            var tags = $('#txtTagM').val();
            var seoKeyword = $('#txtMetakeywordM').val();
            var seoMetaDescription = $('#txtMetaDescriptionM').val();
            var seoPageTitle = $('#txtSeoPageTitleM').val();
            var seoAlias = $('#txtSeoAliasM').val();

            var content = CKEDITOR.instances.txtContent.getData();
            var status = $('#ckStatusM').prop('checked') == true ? 1 : 0;
            var hot = $('#ckHotM').prop('checked');
            var showHome = $('#ckShowHomeM').prop('checked');

            $.ajax({
                type: "POST",
                url: "/Admin/Product/SaveEntity",
                data: {
                    Id: id,
                    Name: name,
                    CategoryId: categoryId,
                    Image: '',
                    Price: price,
                    OriginalPrice: originalPrice,
                    PromotionPrice: promotionPrice,
                    Description: description,
                    Content: content,
                    HomeFlag: showHome,
                    HotFlag: hot,
                    Tags: tags,
                    Unit: unit,
                    Status: status,
                    SeoPageTitle: seoPageTitle,
                    SeoAlias: seoAlias,
                    SeoKeywords: seoKeyword,
                    SeoDescription: seoMetaDescription
                },
                dataType: "json",
                beforeSend: function () {
                    ShopMart22.startLoading();
                },
                success: function (response) {
                    ShopMart22.notify('Update product successful', 'success');
                    $('#modal-add-edit').modal('hide');
                    resetFormMaintainance();

                    ShopMart22.stopLoading();
                    loadData(true);
                },
                error: function () {
                    ShopMart22.notify('Has an error in save product progress', 'error');
                    ShopMart22.stopLoading();
                }
            });
            return false;
        }
    }

    function deleteProduct(id) {
        ShopMart22.confirm('Are you sure to delete?', function () {
            $.ajax({
                type: "POST",
                url: "/Admin/Product/Delete",
                data: { id: that },
                dataType: "json",
                beforeSend: function () {
                    ShopMart22.startLoading();
                },
                success: function (response) {
                    ShopMart22.notify('Delete successful', 'success');
                    ShopMart22.stopLoading();
                    loadData();
                },
                error: function (status) {
                    ShopMart22.notify('Has an error in delete progress', 'error');
                    ShopMart22.stopLoading();
                }
            });
        });
    }

    function initTreeDropDownCategory(selectedId) {
        $.ajax({
            url: "/Admin/ProductCategory/GetAll",
            type: 'GET',
            dataType: 'json',
            async: false,
            success: function (response) {
                var data = [];
                $.each(response, function (i, item) {
                    data.push({
                        id: item.Id,
                        text: item.Name,
                        parentId: item.ParentId,
                        sortOrder: item.SortOrder
                    });
                });
                var arr = ShopMart22.unflattern(data);
                $('#ddlCategoryIdM').combotree({
                    data: arr
                });

                $('#ddlCategoryIdImportExcel').combotree({
                    data: arr
                });
                if (selectedId != undefined) {
                    $('#ddlCategoryIdM').combotree('setValue', selectedId);
                }
            }
        });
    }

    function resetFormMaintainance() {
        $('#hidIdM').val(0);
        $('#txtNameM').val('');
        initTreeDropDownCategory('');

        $('#txtDescM').val('');
        $('#txtUnitM').val('');

        $('#txtPriceM').val('0');
        $('#txtOriginalPriceM').val('');
        $('#txtPromotionPriceM').val('');

        //$('#txtImageM').val('');

        $('#txtTagM').val('');
        $('#txtMetakeywordM').val('');
        $('#txtMetaDescriptionM').val('');
        $('#txtSeoPageTitleM').val('');
        $('#txtSeoAliasM').val('');

        CKEDITOR.instances.txtContent.setData('');
        $('#ckStatusM').prop('checked', true);
        $('#ckHotM').prop('checked', false);
        $('#ckShowHomeM').prop('checked', false);

    }

    function loadCategories() {
        $.ajax({
            type: 'GET',
            
            url: '/admin/product/GetAllCategories',
            dataType: 'json',
            success: function (respone) {
                var render = "<option value=''>--Select category--</option>";
                $.each(respone, function (i, item) {
                    render += "<option value='"+item.Id+"'>"+item.Name+"</option >"
                });
                $('#ddlCategorySearch').html(render);
            },
            error: function (status) {
                console.log(status);
                ShopMart22.notify("Cannot loading product category data", "error");
            }
        });
    }

    function loadData(isPageChanged) {
        var template = $('#table-template').html();
        var render = "";
        $.ajax({
            type: 'GET',
            data: {
                categoryId: $('#ddlCategorySearch').val(),
                keyword: $('#txtKeyword').val(),
                page: ShopMart22.configs.pageIndex,
                pageSize: ShopMart22.configs.pageSize
            },
            url: '/admin/product/GetAllPaging',
            dataType: 'json',
            success: function (respone) {
                console.log(respone);
                $.each(respone.Results, function (i, item) {
                    render += Mustache.render(template, {
                        Id: item.Id,
                        Name: item.Name,
                        Image: item.Image == null ? '<img src="/admin-side/images/user.png" width="25" />' : '<img src="' + item.Image + '" width="25" />',
                        CategoryName: item.ProductCategory.Name,
                        Price: ShopMart22.formatNumber(item.Price, 0),
                        CreatedDate: ShopMart22.dateTimeFormatJson(item.DateCreated),
                        Status: ShopMart22.getStatus(item.Status)
                    });

                    $('#lblTotalRecords').text(respone.RowCount);

                    if (render != '') {
                        $('#tbl-content').html(render);
                    }

                    wrapPaging(respone.RowCount, function () {
                        loadData();
                    }, isPageChanged);
                });
            },
            error: function (status) {
                console.log(status);
                ShopMart22.notify("Cannot loading data", "error");
            }
        });
    }

    function wrapPaging(recordCount, callBack, changePageSize) {
        var totalsize = Math.ceil(recordCount / ShopMart22.configs.pageSize);
        //Unbind pagination if it existed or click change pagesize
        if ($('#paginationUL a').length === 0 || changePageSize === true) {
            $('#paginationUL').empty();
            $('#paginationUL').removeData("twbs-pagination");
            $('#paginationUL').unbind("page");
        }
        //Bind Pagination Event
        $('#paginationUL').twbsPagination({
            totalPages: totalsize,
            visiblePages: 7,
            first: 'Đầu',
            prev: 'Trước',
            next: 'Tiếp',
            last: 'Cuối',
            onPageClick: function (event, p) {
                ShopMart22.configs.pageIndex = p;
                setTimeout(callBack(), 200);
            }
        });
    }
}