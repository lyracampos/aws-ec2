#pragma checksum "/Users/guilhermelyracampos/Documents/profissional/projetos/git/aws-ec2/GLC.AWS.EC2/src/GLC.AWS.EC2.Site/Views/EC2/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7aa120df00561e2f73830028e4e26c7e8e43241"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EC2_Index), @"mvc.1.0.view", @"/Views/EC2/Index.cshtml")]
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
#line 1 "/Users/guilhermelyracampos/Documents/profissional/projetos/git/aws-ec2/GLC.AWS.EC2/src/GLC.AWS.EC2.Site/Views/_ViewImports.cshtml"
using GLC.AWS.EC2.Site;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/guilhermelyracampos/Documents/profissional/projetos/git/aws-ec2/GLC.AWS.EC2/src/GLC.AWS.EC2.Site/Views/_ViewImports.cshtml"
using GLC.AWS.EC2.Site.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7aa120df00561e2f73830028e4e26c7e8e43241", @"/Views/EC2/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c4c64d2ff4b398a3bc6395636b541d0f68916fe", @"/Views/_ViewImports.cshtml")]
    public class Views_EC2_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GLC.AWS.EC2.Site.Models.EC2.EC2InstanceListModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ec2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/guilhermelyracampos/Documents/profissional/projetos/git/aws-ec2/GLC.AWS.EC2/src/GLC.AWS.EC2.Site/Views/EC2/Index.cshtml"
  
    ViewData["Title"] = "Instâncias EC2";

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/guilhermelyracampos/Documents/profissional/projetos/git/aws-ec2/GLC.AWS.EC2/src/GLC.AWS.EC2.Site/Views/EC2/Index.cshtml"
 if (Model.HasInstance)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table table-bordered"">
          <thead>
            <tr>
              <th scope=""col"">Nome</th>
              <th scope=""col"">Id</th>
              <th scope=""col"">Tipo</th>
              <th scope=""col"">Zona</th>
              <th scope=""col"">Status</th>
              <th scope=""col"">Visualizar</th>
            </tr>
          </thead>
          <tbody>
");
#nullable restore
#line 19 "/Users/guilhermelyracampos/Documents/profissional/projetos/git/aws-ec2/GLC.AWS.EC2/src/GLC.AWS.EC2.Site/Views/EC2/Index.cshtml"
               foreach (var instance in Model.Instances)
              {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\n                  <td>");
#nullable restore
#line 22 "/Users/guilhermelyracampos/Documents/profissional/projetos/git/aws-ec2/GLC.AWS.EC2/src/GLC.AWS.EC2.Site/Views/EC2/Index.cshtml"
                 Write(instance.TagName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                  <td>");
#nullable restore
#line 23 "/Users/guilhermelyracampos/Documents/profissional/projetos/git/aws-ec2/GLC.AWS.EC2/src/GLC.AWS.EC2.Site/Views/EC2/Index.cshtml"
                 Write(instance.InstanceId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                  <td>");
#nullable restore
#line 24 "/Users/guilhermelyracampos/Documents/profissional/projetos/git/aws-ec2/GLC.AWS.EC2/src/GLC.AWS.EC2.Site/Views/EC2/Index.cshtml"
                 Write(instance.InstanceType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                  <td>");
#nullable restore
#line 25 "/Users/guilhermelyracampos/Documents/profissional/projetos/git/aws-ec2/GLC.AWS.EC2/src/GLC.AWS.EC2.Site/Views/EC2/Index.cshtml"
                 Write(instance.AvailabilityZone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                  <td><span");
            BeginWriteAttribute("style", " style=\"", 828, "\"", 858, 2);
#nullable restore
#line 26 "/Users/guilhermelyracampos/Documents/profissional/projetos/git/aws-ec2/GLC.AWS.EC2/src/GLC.AWS.EC2.Site/Views/EC2/Index.cshtml"
WriteAttributeValue("", 836, instance.StatusCss(), 836, 21, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 857, ";", 857, 1, true);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 26 "/Users/guilhermelyracampos/Documents/profissional/projetos/git/aws-ec2/GLC.AWS.EC2/src/GLC.AWS.EC2.Site/Views/EC2/Index.cshtml"
                                                      Write(instance.StatusDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\n                  <td>\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7aa120df00561e2f73830028e4e26c7e8e432417453", async() => {
                WriteLiteral("Visualizar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "/Users/guilhermelyracampos/Documents/profissional/projetos/git/aws-ec2/GLC.AWS.EC2/src/GLC.AWS.EC2.Site/Views/EC2/Index.cshtml"
                                                                                          WriteLiteral(instance.InstanceId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                  </td>\n                </tr>\n");
#nullable restore
#line 31 "/Users/guilhermelyracampos/Documents/profissional/projetos/git/aws-ec2/GLC.AWS.EC2/src/GLC.AWS.EC2.Site/Views/EC2/Index.cshtml"
              }

#line default
#line hidden
#nullable disable
            WriteLiteral("          </tbody>\n        </table>\n");
#nullable restore
#line 34 "/Users/guilhermelyracampos/Documents/profissional/projetos/git/aws-ec2/GLC.AWS.EC2/src/GLC.AWS.EC2.Site/Views/EC2/Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("     <div class=\"text-center\">\n            <h1 class=\"display-4\">Instâncias EC2</h1>\n            <p>Nenhuma instância EC2 foi encontrada na zona configurada. Reveja configurações.</p>\n    </div>\n");
#nullable restore
#line 41 "/Users/guilhermelyracampos/Documents/profissional/projetos/git/aws-ec2/GLC.AWS.EC2/src/GLC.AWS.EC2.Site/Views/EC2/Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GLC.AWS.EC2.Site.Models.EC2.EC2InstanceListModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
