#pragma checksum "C:\Users\pc\source\repos\Udemy.BankApp\Udemy.BankApp.Web\Views\Account\Create.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "338766aeb1eddf643be48a1b39e98234fc6c973585b3e60fdce4420bd2d188be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Create), @"mvc.1.0.view", @"/Views/Account/Create.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 3 "C:\Users\pc\source\repos\Udemy.BankApp\Udemy.BankApp.Web\Views\_ViewImports.cshtml"
using Udemy.BankApp.Web.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"338766aeb1eddf643be48a1b39e98234fc6c973585b3e60fdce4420bd2d188be", @"/Views/Account/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"88625322f79fe5479c74aeb1bc3b7c01eefda934b02551a01412f4bc1b416398", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Account_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UserListModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Udemy.BankApp.Web.TagHelpers.GetAccountCount __Udemy_BankApp_Web_TagHelpers_GetAccountCount;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\pc\source\repos\Udemy.BankApp\Udemy.BankApp.Web\Views\Account\Create.cshtml"
  
	Layout = "~/views/shared/_layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n\t<div class=\"col-6\">\r\n\t\t<h3>Hesap Eklenecek Kişinin Bilgileri</h3>\r\n\t\t<p>\r\n\t\t\tKullanıcının Adı : ");
#nullable restore
#line 10 "C:\Users\pc\source\repos\Udemy.BankApp\Udemy.BankApp.Web\Views\Account\Create.cshtml"
                 Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t</p>\r\n\t\t<p>\r\n\t\t\tKullanıcının Adı : ");
#nullable restore
#line 13 "C:\Users\pc\source\repos\Udemy.BankApp\Udemy.BankApp.Web\Views\Account\Create.cshtml"
                 Write(Model.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t</p>\r\n\t\t<p>\r\n\t\t\tAktif Hesap Sayısı : ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("getAccountCount", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "338766aeb1eddf643be48a1b39e98234fc6c973585b3e60fdce4420bd2d188be5195", async() => {
            }
            );
            __Udemy_BankApp_Web_TagHelpers_GetAccountCount = CreateTagHelper<global::Udemy.BankApp.Web.TagHelpers.GetAccountCount>();
            __tagHelperExecutionContext.Add(__Udemy_BankApp_Web_TagHelpers_GetAccountCount);
#nullable restore
#line 16 "C:\Users\pc\source\repos\Udemy.BankApp\Udemy.BankApp.Web\Views\Account\Create.cshtml"
__Udemy_BankApp_Web_TagHelpers_GetAccountCount.ApplicationUserId = Model.ID;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("application-user-id", __Udemy_BankApp_Web_TagHelpers_GetAccountCount.ApplicationUserId, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t</p>\r\n\t</div>\r\n\t<div class=\"col-6\">\r\n\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "338766aeb1eddf643be48a1b39e98234fc6c973585b3e60fdce4420bd2d188be6660", async() => {
                WriteLiteral("\r\n\t\t\t<input type=\"hidden\" name=\"ApplicationUserID\"");
                BeginWriteAttribute("value", " value=\"", 522, "\"", 539, 1);
#nullable restore
#line 21 "C:\Users\pc\source\repos\Udemy.BankApp\Udemy.BankApp.Web\Views\Account\Create.cshtml"
WriteAttributeValue("", 530, Model.ID, 530, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@"/>
			<div class=""mb-3"">
				<label class=""form-label"">Hesap Numarası</label>
				<input type=""number"" class=""form-control"" name=""AccountNumber""/>
			</div>
			<div class=""mb-3"">
				<label class=""form-label"">Bakiye</label>
				<input type=""number"" class=""form-control"" name=""Balance"" />
			</div>
			<div class=""mb-3"">
				<button class=""btn btn-primary"">Kaydet</button>
			</div>
		");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t</div>\r\n</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UserListModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
