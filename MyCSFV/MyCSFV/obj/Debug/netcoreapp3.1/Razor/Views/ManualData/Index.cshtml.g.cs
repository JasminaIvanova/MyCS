#pragma checksum "C:\Users\Jessy\source\repos\MyCSFV\MyCSFV\Views\ManualData\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac239094b4076964ce788fce8f62eff6d6090813"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ManualData_Index), @"mvc.1.0.view", @"/Views/ManualData/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac239094b4076964ce788fce8f62eff6d6090813", @"/Views/ManualData/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c1e73cada8e7cbe12651a73c39532112e17e999", @"/Views/_ViewImports.cshtml")]
    public class Views_ManualData_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ManualData", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac239094b4076964ce788fce8f62eff6d60908134466", async() => {
                WriteLiteral(@"
    <div class=""row"">
        <div class=""col"">
            <input type=""text"" name=""Account_Number"" id=""Account_Number"" class=""form-control"" placeholder=""Account_Number"">
        </div>
        <div class=""col"">
            <input type=""text"" name=""Account_Type"" id=""Account_Type"" class=""form-control"" placeholder=""Account_Type"">
        </div>
        <div class=""col"">
            <input type=""text"" name=""Final_Decision"" id=""Final_Decision"" class=""form-control"" placeholder=""Final_Decision"">
        </div>
    </div>
    <div class=""row"">
        <div class=""col"">
            <input type=""text"" name=""Current_Delinquency_status"" id=""Current_Delinquency_status"" class=""form-control"" placeholder=""Current_Delinquency_status"">
        </div>
        <div class=""col"">
            <input type=""text"" name=""Application_Date"" id=""Application_Date"" class=""form-control"" placeholder=""Application_Date"">
        </div>
        <div class=""col"">
            <input type=""text"" name=""Application_Score"" id=""A");
                WriteLiteral(@"pplication_Score"" class=""form-control"" placeholder=""Application_Score"">
        </div>
    </div>
    <div class=""row"">
        <div class=""col"">
            <input type=""text"" name=""Cheque_Card_Flag"" id=""Cheque_Card_Flag"" class=""form-control"" placeholder=""Cheque_Card_Flag"">
        </div>
        <div class=""col"">
            <input type=""text"" name=""Existing_Customer_Flag"" id=""Existing_Customer_Flag"" class=""form-control"" placeholder=""Existing_Customer_Flag"">
        </div>
        <div class=""col"">
            <input type=""text"" name=""Gross_Annual_Income"" id=""Gross_Annual_Income"" class=""form-control"" placeholder=""Gross_Annual_Income"">
        </div>
    </div>
    <div class=""row"">
        <div class=""col"">
            <input type=""text"" name=""Home_Telephone_Number"" id=""Home_Telephone_Number"" class=""form-control"" placeholder=""Home_Telephone_Number"">
        </div>
        <div class=""col"">
            <input type=""text"" name=""Insurance_Required"" id=""Insurance_Required"" class=""form-control");
                WriteLiteral(@""" placeholder=""Insurance_Required"">
        </div>
        <div class=""col"">
            <input type=""text"" name=""Loan_Amount"" id=""Loan_Amount"" class=""form-control"" placeholder=""Loan_Amount"">
        </div>
    </div>
    <div class=""row"">
        <div class=""col"">
            <input type=""text"" name=""Loan_Payment_Frequency"" id=""Loan_Payment_Frequency"" class=""form-control"" placeholder=""Loan_Payment_Frequency"">
        </div>
        <div class=""col"">
            <input type=""text"" name=""Loan_Payment_Method"" id=""Loan_Payment_Method"" class=""form-control"" placeholder=""Loan_Payment_Method"">
        </div>
        <div class=""col"">
            <input type=""text"" name=""Marital_Status"" id=""Marital_Status"" class=""form-control"" placeholder=""Marital_Status"">
        </div>
    </div>
    <div class=""row"">
        <div class=""col"">
            <input type=""text"" name=""Number_of_Dependants"" id=""Number_of_Dependants"" class=""form-control"" placeholder=""Number_of_Dependants"">
        </div>
        <div ");
                WriteLiteral(@"class=""col"">
            <input type=""text"" name=""Number_of_Payments"" id=""Number_of_Payments"" class=""form-control"" placeholder=""Number_of_Payments"">
        </div>
        <div class=""col"">
            <input type=""text"" name=""Occupation_Code"" id=""Occupation_Code"" class=""form-control"" placeholder=""Occupation_Code"">
        </div>
    </div>
    <div class=""row"">
        <div class=""col"">
            <input type=""text"" name=""Promotion_Type"" id=""Promotion_Type"" class=""form-control"" placeholder=""Promotion_Type"">
        </div>
        <div class=""col"">
            <input type=""text"" name=""Residential_Status"" id=""Residential_Status"" class=""form-control"" placeholder=""Residential_Status"">
        </div>
        <div class=""col"">
            <input type=""text"" name=""Time_at_Address"" id=""Time_at_Address"" class=""form-control"" placeholder=""Time_at_Address"">
        </div>
    </div>
    <div class=""row"">
        <div class=""col"">
            <input type=""text"" name=""Time_in_Employment"" id=""Time_in_E");
                WriteLiteral(@"mployment"" class=""form-control"" placeholder=""Time_in_Employment"">
        </div>
        <div class=""col"">
            <input type=""text"" name=""Time_with_Bank"" id=""Time_with_Bank"" class=""form-control"" placeholder=""Time_with_Bank"">
        </div>
        <div class=""col"">
            <input type=""text"" name=""Weight_Factor"" id=""Weight_Factor"" class=""form-control"" placeholder=""Weight_Factor"">
        </div>
    </div>
    <div class=""row"">
        <div class=""col"">
            <input type=""text"" name=""GB_Flag"" id=""GB_Flag"" class=""form-control"" placeholder=""GB_Flag"">
        </div>
        <div class=""col"">
            <input type=""text"" name=""Age_of_Applicant"" id=""Age_of_Applicant"" class=""form-control"" placeholder=""Age_of_Applicant"">
        </div>
        <div class=""col"">
            <input type=""text"" name=""Application_Month"" id=""Application_Month"" class=""form-control"" placeholder=""Application_Month"">
        </div>
    </div>
    <div class=""row"">
        <div class=""col"">
            <");
                WriteLiteral(@"input type=""text"" name=""Bureau_Score"" id=""Bureau_Score"" class=""form-control"" placeholder=""Bureau_Score"">
        </div>
        <div class=""col"">
            <input type=""text"" name=""SP_ER_Reference"" id=""SP_ER_Reference"" class=""form-control"" placeholder=""SP_ER_Reference"">
        </div>
        <div class=""col"">
            <input type=""text"" name=""SP_Number_Of_Searches_L6M"" id=""SP_Number_Of_Searches_L6M"" class=""form-control"" placeholder=""SP_Number_Of_Searches_L6M"">
        </div>
    </div>
    <div class=""row"">
        <div class=""col"">
            <input type=""text"" name=""SP_Number_of_CCJs"" id=""SP_Number_of_CCJs"" class=""form-control"" placeholder=""SP_Number_of_CCJs"">
        </div>
        <div class=""col"">
            <input type=""text"" name=""loan_to_income"" id=""loan_to_income"" class=""form-control"" placeholder=""loan_to_income"">
        </div>
        <div class=""col"">
            <input type=""text"" name=""split"" id=""split"" class=""form-control"" placeholder=""split"">
        </div>
    </div");
                WriteLiteral(">\r\n\r\n    <div class=\"row\">\r\n        <div class=\"col\">\r\n            <button type=\"submit\" class=\"btn btn-primary\">Submit</button>\r\n        </div>\r\n    </div>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
