#pragma checksum "D:\American English File\ShopMart22\ShopMart22\Areas\Admin\Views\ProductCategory\_AddEditModal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e853c837749bae25c772d9a677fd5a3abb6f95b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ProductCategory__AddEditModal), @"mvc.1.0.view", @"/Areas/Admin/Views/ProductCategory/_AddEditModal.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/ProductCategory/_AddEditModal.cshtml", typeof(AspNetCore.Areas_Admin_Views_ProductCategory__AddEditModal))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "D:\American English File\ShopMart22\ShopMart22\Areas\Admin\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#line 2 "D:\American English File\ShopMart22\ShopMart22\Areas\Admin\Views\_ViewImports.cshtml"
using ShopMart22;

#line default
#line hidden
#line 3 "D:\American English File\ShopMart22\ShopMart22\Areas\Admin\Views\_ViewImports.cshtml"
using ShopMart22.Models;

#line default
#line hidden
#line 4 "D:\American English File\ShopMart22\ShopMart22\Areas\Admin\Views\_ViewImports.cshtml"
using ShopMart22.Data.Entities;

#line default
#line hidden
#line 5 "D:\American English File\ShopMart22\ShopMart22\Areas\Admin\Views\_ViewImports.cshtml"
using ShopMart22.Application.ViewModels.System;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e853c837749bae25c772d9a677fd5a3abb6f95b", @"/Areas/Admin/Views/ProductCategory/_AddEditModal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10def06a71f1c590d257b25b549eadce64fa6a33", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_ProductCategory__AddEditModal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("frmMaintainance"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 658, true);
            WriteLiteral(@"<div id=""modal-add-edit"" class=""modal fade"" role=""dialog"" aria-labelledby=""exampleModalLongTitle"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"" style=""width:750px;"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLongTitle"">Category update</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <div id=""horizontal-form"">
                    ");
            EndContext();
            BeginContext(658, 5931, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e853c837749bae25c772d9a677fd5a3abb6f95b5796", async() => {
                BeginContext(721, 5861, true);
                WriteLiteral(@"

                        <div class=""form-group row"">
                            <input type=""hidden"" id=""hidIdM"" value=""0"" />
                            <label for=""txtNameM"" class=""col-sm-2 control-label no-padding-right"">Name</label>
                            <div class=""col-sm-10"">
                                <input type=""text"" name=""txtNameM"" class=""form-control"" id=""txtNameM"" placeholder=""Name of category"">
                            </div>
                        </div>
                        <div class=""form-group row"">
                            <label class=""col-sm-2 control-label no-padding-right"">Parent</label>
                            <div class=""col-sm-10"">
                                <input id=""ddlCategoryIdM"" class=""form-control"" name=""ddlCategoryIdM"" value="""">
                            </div>
                        </div>
                        <div class=""form-group row"">
                            <label for=""txtAliasM"" class=""col-sm-2 control-label n");
                WriteLiteral(@"o-padding-right"">Alias</label>
                            <div class=""col-sm-10"">
                                <input type=""text"" name=""txtAliasM"" class=""form-control"" id=""txtAliasM"">
                            </div>
                        </div>
                        <div class=""form-group row"">
                            <label for=""txtDescM"" class=""col-sm-2 control-label no-padding-right"">Description</label>
                            <div class=""col-sm-10"">
                                <textarea rows=""3"" name=""txtDescM"" class=""form-control"" id=""txtDescM""></textarea>
                            </div>
                        </div>
                        <div class=""form-group row"">
                            <label for=""txtOrderM"" class=""col-sm-2 control-label no-padding-right"">Sort Order</label>
                            <div class=""col-sm-10"">
                                <input type=""number"" name=""txtOrderM"" class=""form-control"" id=""txtOrderM"">
                      ");
                WriteLiteral(@"      </div>
                        </div>
                        <div class=""form-group row"">
                            <label for=""txtHomeOrderM"" class=""col-sm-2 control-label no-padding-right"">Home Order</label>
                            <div class=""col-sm-10"">
                                <input type=""number"" name=""txtHomeOrderM"" class=""form-control"" id=""txtHomeOrderM"">
                            </div>
                        </div>
                        <div class=""form-group row"">
                            <label for=""txtImageM"" class=""col-sm-2 control-label no-padding-right"">Images</label>
                            <div class=""col-sm-10"">
                                <div class=""input-group"">
                                    <input type=""text"" name=""txtImage"" class=""form-control"" id=""txtImage"" />
                                    <input type=""file"" id=""fileInputImage"" style=""display:none"" />
                                    <span class=""input-group-btn"">
     ");
                WriteLiteral(@"                                   <input type=""button"" id=""btnSelectImg"" class=""btn btn-default"" value=""Browser"" />
                                    </span>
                                </div><!-- /input-group -->

                            </div>

                        </div>
                        <div class=""form-group row"">
                            <label for=""txtSeoPageTitleM"" class=""col-sm-2 control-label no-padding-right"">SEO Title</label>
                            <div class=""col-sm-10"">
                                <input type=""text"" name=""txtSeoPageTitleM"" class=""form-control"" id=""txtSeoPageTitleM"">
                            </div>
                        </div>
                        <div class=""form-group row"">
                            <label for=""txtSeoAliasM"" class=""col-sm-2 control-label no-padding-right"">URL SEO</label>
                            <div class=""col-sm-10"">
                                <input type=""text"" name=""txtSeoAliasM"" class=""form");
                WriteLiteral(@"-control"" id=""txtSeoAliasM"">
                            </div>
                        </div>
                        <div class=""form-group row"">
                            <label for=""txtSeoKeywordM"" class=""col-sm-2 control-label no-padding-right"">SEO Keyword</label>
                            <div class=""col-sm-10"">
                                <input type=""text"" name=""txtSeoKeywordM"" class=""form-control"" id=""txtSeoKeywordM"">
                            </div>
                        </div>
                        <div class=""form-group row"">
                            <label for=""txtSeoDescriptionM"" class=""col-sm-2 control-label no-padding-right"">SEO Description</label>
                            <div class=""col-sm-10"">
                                <textarea rows=""3"" name=""txtSeoDescriptionM"" class=""form-control"" id=""txtSeoDescriptionM""></textarea>
                            </div>
                        </div>
                        <div class=""form-group row"">
             ");
                WriteLiteral(@"               <div class=""col-sm-offset-2 col-sm-10"">
                                <div>
                                    <label>
                                        <input type=""checkbox"" checked=""checked"" id=""ckStatusM"">
                                        <span class=""text"">Active.</span>
                                    </label>
                                    <label>
                                        <input type=""checkbox"" id=""ckShowHomeM"">
                                        <span class=""text"">Show on home.</span>
                                    </label>
                                </div>
                            </div>
                        </div>
                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6589, 354, true);
            WriteLiteral(@"
                </div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" id=""btnCancel"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                <button type=""button"" id=""btnSave"" class=""btn btn-primary"">Save changes</button>
            </div>
        </div>
    </div>
</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
