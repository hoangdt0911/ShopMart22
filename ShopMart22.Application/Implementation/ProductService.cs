using AutoMapper;
using AutoMapper.QueryableExtensions;
using OfficeOpenXml;
using ShopMart22.Application.Interfaces;
using ShopMart22.Application.ViewModels.Product;
using ShopMart22.Data.Entities;
using ShopMart22.Data.Enums;
using ShopMart22.Data.IRepositories;
using ShopMart22.Infrastructure.Interfaces;
using ShopMart22.Utilities.Constants;
using ShopMart22.Utilities.Dtos;
using ShopMart22.Utilities.Helpers;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ShopMart22.Application.Implementation
{
    public class ProductService : IProductService
    {
        IProductRepository _productRepository;

        ITagRepository _tagRepository;

        IProductTagRepository _productTagRepository;

        IUnitOfWork _unitOfWork;

        //private IRepository<Tag, string> _tagRepository;

        public ProductService(IProductRepository productRepository, ITagRepository tagRepository,
            IProductTagRepository productTagRepository, IUnitOfWork unitOfWork)
        {
            _productRepository = productRepository;
            _tagRepository = tagRepository;
            _productTagRepository = productTagRepository;
            _unitOfWork = unitOfWork;
        }

        public ProductViewModel Add(ProductViewModel productVm)
        {
            List<ProductTag> productTags = new List<ProductTag>();
            if (!string.IsNullOrEmpty(productVm.Tags))
            {
                string[] tags = productVm.Tags.Split(',');
                foreach (string t in tags)
                {
                    var tagId = TextHelper.ToUnsignString(t);
                    if (!_tagRepository.FindAll(x => x.Id == tagId).Any())
                    {
                        Tag tag = new Tag
                        {
                            Id = tagId,
                            Name = t,
                            Type = CommonConstants.ProductTag
                        };
                        _tagRepository.Add(tag);
                    }

                    ProductTag productTag = new ProductTag
                    {
                        TagId = tagId
                    };
                    productTags.Add(productTag);
                }
                Product product = Mapper.Map<ProductViewModel, Product>(productVm);
                foreach (var productTag in productTags)
                {
                    product.ProductTags.Add(productTag);
                }
                _productRepository.Add(product);
            }
            return productVm;
        }

        public void Delete(int id)
        {
            _productRepository.Remove(id);
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public List<ProductViewModel> GetAll()
        {
            return _productRepository.FindAll(x => x.ProductCategory).ProjectTo<ProductViewModel>().ToList();
        }

        public PagedResult<ProductViewModel> GetAllPaging(int? categoryId, string keyword, int page, int pageSize)
        {
            //var query = _productRepository.FindAll(x => x.Status == Status.Active);
            var query = _productRepository.FindAll();

            if (!string.IsNullOrEmpty(keyword))
            {
                query = query.Where(x => x.Name.Contains(keyword));
            }

            if(categoryId.HasValue)
            {
                query = query.Where(x => x.CategoryId == categoryId.Value);
            }

            int totalRow = query.Count();

            query = query.OrderByDescending(x => x.DateCreated).Skip((page - 1) * pageSize).Take(pageSize);

            var data = query.ProjectTo<ProductViewModel>().ToList();

            var paginationSet = new PagedResult<ProductViewModel>()
            {
                Results = data,

                CurrentPage = page,

                RowCount = totalRow,

                PageSize = pageSize
            };
            return paginationSet;
        }

        public ProductViewModel GetById(int id)
        {
            return Mapper.Map<Product, ProductViewModel>(_productRepository.FindById(id));
        }

        public void ImportExcel(string filePath, int categoryId)
        {
            using (var package = new ExcelPackage(new FileInfo(filePath)))
            {
                ExcelWorksheet workSheet = package.Workbook.Worksheets[1];
                Product product;
                for (int i = workSheet.Dimension.Start.Row + 1; i <= workSheet.Dimension.End.Row; i++)
                {
                    if (workSheet.Cells[i, 1].Value == null) break;
                    else
                    {
                        product = new Product();

                        product.CategoryId = categoryId;

                        product.Name = workSheet.Cells[i, 1].Value.ToString();

                        product.Description = workSheet.Cells[i, 2].Value.ToString();

                        decimal.TryParse(workSheet.Cells[i, 3].Value.ToString(), out var originalPrice);
                        product.OriginalPrice = originalPrice;

                        decimal.TryParse(workSheet.Cells[i, 4].Value.ToString(), out var price);
                        product.Price = price;
                        decimal.TryParse(workSheet.Cells[i, 5].Value.ToString(), out var promotionPrice);

                        product.PromotionPrice = promotionPrice;

                        product.Content = workSheet.Cells[i, 6].Value.ToString();

                        product.SeoKeywords = workSheet.Cells[i, 7].Value.ToString();

                        product.SeoDescription = workSheet.Cells[i, 8].Value.ToString();

                        bool.TryParse(workSheet.Cells[i, 9].Value.ToString(), out var status);
                        if (status == true) product.Status = Status.Active;
                        else product.Status = Status.InActive;

                        bool.TryParse(workSheet.Cells[i, 10].Value.ToString(), out var homeFlag);
                        product.HomeFlag = homeFlag;

                        bool.TryParse(workSheet.Cells[i, 11].Value.ToString(), out var hotFlag);
                        product.HotFlag = hotFlag;

                        //product.Status = Status.Active;

                        _productRepository.Add(product);
                    }
                    
                }
            }
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }

        public void Update(ProductViewModel productVm)
        {
            List<ProductTag> productTags = new List<ProductTag>();

            if (!string.IsNullOrEmpty(productVm.Tags))
            {
                string[] tags = productVm.Tags.Split(',');
                foreach (string t in tags)
                {
                    var tagId = TextHelper.ToUnsignString(t);
                    if (!_tagRepository.FindAll(x => x.Id == tagId).Any())
                    {
                        Tag tag = new Tag();
                        tag.Id = tagId;
                        tag.Name = t;
                        tag.Type = CommonConstants.ProductTag;
                        _tagRepository.Add(tag);
                    }
                    _productTagRepository.RemoveMultiple(_productTagRepository.FindAll(x => x.Id == productVm.Id).ToList());
                    ProductTag productTag = new ProductTag
                    {
                        TagId = tagId
                    };
                    productTags.Add(productTag);
                }
            }

            var product = Mapper.Map<ProductViewModel, Product>(productVm);
            foreach (var productTag in productTags)
            {
                product.ProductTags.Add(productTag);
            }
            _productRepository.Update(product);
        }
    }
}
