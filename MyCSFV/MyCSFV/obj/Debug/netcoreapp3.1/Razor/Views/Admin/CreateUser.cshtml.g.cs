#pragma checksum "C:\Users\Jessy\source\repos\MyCSFV\MyCSFV\Views\Admin\CreateUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09f3d72ac3bd153ebbb76d37978ebcf113b254d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_CreateUser), @"mvc.1.0.view", @"/Views/Admin/CreateUser.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Jessy\source\repos\MyCSFV\MyCSFV\Views\_ViewImports.cshtml"
using MyCSFV;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Jessy\source\repos\MyCSFV\MyCSFV\Views\_ViewImports.cshtml"
using MyCSFV.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09f3d72ac3bd153ebbb76d37978ebcf113b254d7", @"/Views/Admin/CreateUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c1e73cada8e7cbe12651a73c39532112e17e999", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_CreateUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Jessy\source\repos\MyCSFV\MyCSFV\Views\Admin\CreateUser.cshtml"
  
    ViewData["Title"] = "Create Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>CreatePage</h1>\r\n\r\n");
#nullable restore
#line 8 "C:\Users\Jessy\source\repos\MyCSFV\MyCSFV\Views\Admin\CreateUser.cshtml"
 using (Html.BeginForm("CreateUser", "Admin", FormMethod.Post)) 
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""row"">
    <div class="" col-md-6"">
        <label class=""control-label"">User Email</label>
        <input type =""text"" name=""txtEmail"" class="" form-control""/> 
    </div>
    <div class="" col-md-6"">
        <label class=""control-label"">Password</label>
        <input type=""text"" name=""txtPassword"" class="" form-control"" />
    </div>
</div>
<div class=""row"">
    <div class="" col-md-12"">
        <button type =""submit"" value=""Submit"" class="" btn btn-primary"">Save</button>
    </div>
</div>
");
#nullable restore
#line 25 "C:\Users\Jessy\source\repos\MyCSFV\MyCSFV\Views\Admin\CreateUser.cshtml"
}

#line default
#line hidden
#nullable disable
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
