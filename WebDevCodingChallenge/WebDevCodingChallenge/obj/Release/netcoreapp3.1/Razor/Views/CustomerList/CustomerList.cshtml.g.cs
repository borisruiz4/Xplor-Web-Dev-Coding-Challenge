#pragma checksum "C:\Users\boris\OneDrive\Desktop\Development\Job\Xplor-Web-Dev-Coding-Challenge\WebDevCodingChallenge\WebDevCodingChallenge\Views\CustomerList\CustomerList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "921e46ec9fd7eb412ade6d290af8ba4d6e1671dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CustomerList_CustomerList), @"mvc.1.0.view", @"/Views/CustomerList/CustomerList.cshtml")]
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
#line 1 "C:\Users\boris\OneDrive\Desktop\Development\Job\Xplor-Web-Dev-Coding-Challenge\WebDevCodingChallenge\WebDevCodingChallenge\Views\_ViewImports.cshtml"
using WebDevCodingChallenge;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\boris\OneDrive\Desktop\Development\Job\Xplor-Web-Dev-Coding-Challenge\WebDevCodingChallenge\WebDevCodingChallenge\Views\_ViewImports.cshtml"
using WebDevCodingChallenge.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"921e46ec9fd7eb412ade6d290af8ba4d6e1671dc", @"/Views/CustomerList/CustomerList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df025c81fe8d921e5c17794f433a4a324e6f3a44", @"/Views/_ViewImports.cshtml")]
    public class Views_CustomerList_CustomerList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CustomerListModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\boris\OneDrive\Desktop\Development\Job\Xplor-Web-Dev-Coding-Challenge\WebDevCodingChallenge\WebDevCodingChallenge\Views\CustomerList\CustomerList.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n\r\n        console.log(\"Fetching Table...\");\r\n\r\n        var customers = new Array();\r\n        customers.push([\"Customer Id\", \"First Name\", \"Last Name\", \"Email\", \"Int Phone Number\", \"Country Code\", \"Gender\", \"Balance Total\"]);\r\n\r\n");
#nullable restore
#line 15 "C:\Users\boris\OneDrive\Desktop\Development\Job\Xplor-Web-Dev-Coding-Challenge\WebDevCodingChallenge\WebDevCodingChallenge\Views\CustomerList\CustomerList.cshtml"
         foreach (var customer in Model.Customers)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("           ");
                WriteLiteral("customers.push([\"");
#nullable restore
#line 17 "C:\Users\boris\OneDrive\Desktop\Development\Job\Xplor-Web-Dev-Coding-Challenge\WebDevCodingChallenge\WebDevCodingChallenge\Views\CustomerList\CustomerList.cshtml"
                         Write(customer.id);

#line default
#line hidden
#nullable disable
                WriteLiteral("\", \"");
#nullable restore
#line 17 "C:\Users\boris\OneDrive\Desktop\Development\Job\Xplor-Web-Dev-Coding-Challenge\WebDevCodingChallenge\WebDevCodingChallenge\Views\CustomerList\CustomerList.cshtml"
                                         Write(customer.firstName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\", \"");
#nullable restore
#line 17 "C:\Users\boris\OneDrive\Desktop\Development\Job\Xplor-Web-Dev-Coding-Challenge\WebDevCodingChallenge\WebDevCodingChallenge\Views\CustomerList\CustomerList.cshtml"
                                                                Write(customer.lastName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\", \"");
#nullable restore
#line 17 "C:\Users\boris\OneDrive\Desktop\Development\Job\Xplor-Web-Dev-Coding-Challenge\WebDevCodingChallenge\WebDevCodingChallenge\Views\CustomerList\CustomerList.cshtml"
                                                                                      Write(customer.email);

#line default
#line hidden
#nullable disable
                WriteLiteral("\", \"");
#nullable restore
#line 17 "C:\Users\boris\OneDrive\Desktop\Development\Job\Xplor-Web-Dev-Coding-Challenge\WebDevCodingChallenge\WebDevCodingChallenge\Views\CustomerList\CustomerList.cshtml"
                                                                                                         Write(customer.phone_number);

#line default
#line hidden
#nullable disable
                WriteLiteral("\", \"");
#nullable restore
#line 17 "C:\Users\boris\OneDrive\Desktop\Development\Job\Xplor-Web-Dev-Coding-Challenge\WebDevCodingChallenge\WebDevCodingChallenge\Views\CustomerList\CustomerList.cshtml"
                                                                                                                                   Write(customer.country_code);

#line default
#line hidden
#nullable disable
                WriteLiteral("\".toUpperCase(),\"");
#nullable restore
#line 17 "C:\Users\boris\OneDrive\Desktop\Development\Job\Xplor-Web-Dev-Coding-Challenge\WebDevCodingChallenge\WebDevCodingChallenge\Views\CustomerList\CustomerList.cshtml"
                                                                                                                                                                          Write(customer.gender);

#line default
#line hidden
#nullable disable
                WriteLiteral("\".toUpperCase(),\"$");
#nullable restore
#line 17 "C:\Users\boris\OneDrive\Desktop\Development\Job\Xplor-Web-Dev-Coding-Challenge\WebDevCodingChallenge\WebDevCodingChallenge\Views\CustomerList\CustomerList.cshtml"
                                                                                                                                                                                                            Write(customer.balance);

#line default
#line hidden
#nullable disable
                WriteLiteral("\"]);\r\n");
#nullable restore
#line 18 "C:\Users\boris\OneDrive\Desktop\Development\Job\Xplor-Web-Dev-Coding-Challenge\WebDevCodingChallenge\WebDevCodingChallenge\Views\CustomerList\CustomerList.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        console.log(customers)\r\n\r\n        GenerateTable(customers);\r\n\r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h6 class=\"display-4\">Customer Table</h6>\r\n    <h6 class=\"mt-lg-2\">\r\n        Data feteched from : <a");
            BeginWriteAttribute("class", " class=\"", 866, "\"", 874, 0);
            EndWriteAttribute();
            WriteLiteral(" href=\"https://getinvoices.azurewebsites.net/api/\" target=\"_blank\">https://getinvoices.azurewebsites.net/api/</a>\r\n    </h6>\r\n</div>\r\n\r\n");
#nullable restore
#line 34 "C:\Users\boris\OneDrive\Desktop\Development\Job\Xplor-Web-Dev-Coding-Challenge\WebDevCodingChallenge\WebDevCodingChallenge\Views\CustomerList\CustomerList.cshtml"
 if (Model.Customers != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div id=""bootstrap_alert"" class=""alert alert-success"" role=""alert"">
    </div>
    <div class=""center-content"">
        <div id=""customerTable"">
        </div>
        <button id=""Create_Customer"" class=""btn btn-primary"" type=""submit"">Create Customer</button>
        <button id=""Reset_Table"" class=""btn btn-primary"" type=""submit"">Reset Table</button>

    </div>
");
#nullable restore
#line 45 "C:\Users\boris\OneDrive\Desktop\Development\Job\Xplor-Web-Dev-Coding-Challenge\WebDevCodingChallenge\WebDevCodingChallenge\Views\CustomerList\CustomerList.cshtml"
}
else if (Model.ErrorMessage != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\" role=\"alert\">\r\n        ");
#nullable restore
#line 49 "C:\Users\boris\OneDrive\Desktop\Development\Job\Xplor-Web-Dev-Coding-Challenge\WebDevCodingChallenge\WebDevCodingChallenge\Views\CustomerList\CustomerList.cshtml"
   Write(Model.ErrorMessage);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 51 "C:\Users\boris\OneDrive\Desktop\Development\Job\Xplor-Web-Dev-Coding-Challenge\WebDevCodingChallenge\WebDevCodingChallenge\Views\CustomerList\CustomerList.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\" role=\"alert\">\r\n        Error Fetching Table\r\n    </div>\r\n");
#nullable restore
#line 57 "C:\Users\boris\OneDrive\Desktop\Development\Job\Xplor-Web-Dev-Coding-Challenge\WebDevCodingChallenge\WebDevCodingChallenge\Views\CustomerList\CustomerList.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div>
    <label class=""disclaimer"">
    Disclaimer : Some elements such as <b>country_code</b> and <b>balance</b> will not update at the server side, even when the
        POST request is sent. Therefore, <b>Country Code</b> is simulated based on the <b>phone_number</b> entries on the client side,
        while <b>balance</b> remains unmodified from the server.
    </label>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CustomerListModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
