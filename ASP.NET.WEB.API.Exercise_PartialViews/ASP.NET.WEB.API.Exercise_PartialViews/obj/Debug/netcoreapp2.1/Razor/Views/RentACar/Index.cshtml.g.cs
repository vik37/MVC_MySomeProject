#pragma checksum "C:\Users\vikto\source\repos\MVC\Exercise\ASP.NET.WEB.API.Exercise_PartialViews\ASP.NET.WEB.API.Exercise_PartialViews\Views\RentACar\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2dd92f937b56fc3821f62f8e331aabcc68e811e7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RentACar_Index), @"mvc.1.0.view", @"/Views/RentACar/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/RentACar/Index.cshtml", typeof(AspNetCore.Views_RentACar_Index))]
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
#line 1 "C:\Users\vikto\source\repos\MVC\Exercise\ASP.NET.WEB.API.Exercise_PartialViews\ASP.NET.WEB.API.Exercise_PartialViews\Views\_ViewImports.cshtml"
using ASP.NET.WEB.API.Exercise_PartialViews;

#line default
#line hidden
#line 2 "C:\Users\vikto\source\repos\MVC\Exercise\ASP.NET.WEB.API.Exercise_PartialViews\ASP.NET.WEB.API.Exercise_PartialViews\Views\_ViewImports.cshtml"
using ASP.NET.WEB.API.Exercise_PartialViews.Models;

#line default
#line hidden
#line 3 "C:\Users\vikto\source\repos\MVC\Exercise\ASP.NET.WEB.API.Exercise_PartialViews\ASP.NET.WEB.API.Exercise_PartialViews\Views\_ViewImports.cshtml"
using ASP.NET.WEB.API.Exercise_PartialViews.Models.Domain;

#line default
#line hidden
#line 4 "C:\Users\vikto\source\repos\MVC\Exercise\ASP.NET.WEB.API.Exercise_PartialViews\ASP.NET.WEB.API.Exercise_PartialViews\Views\_ViewImports.cshtml"
using ASP.NET.WEB.API.Exercise_PartialViews.Models.ViewModels;

#line default
#line hidden
#line 5 "C:\Users\vikto\source\repos\MVC\Exercise\ASP.NET.WEB.API.Exercise_PartialViews\ASP.NET.WEB.API.Exercise_PartialViews\Views\_ViewImports.cshtml"
using ASP.NET.WEB.API.Exercise_PartialViews.Models.Enum;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2dd92f937b56fc3821f62f8e331aabcc68e811e7", @"/Views/RentACar/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"236270e78001356dbffa9aa16ab18cc0b90d4e73", @"/Views/_ViewImports.cshtml")]
    public class Views_RentACar_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<VehiclesVM>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(25, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(42, 10556, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e3924fd999c4752850b070fd4d078d3", async() => {
                BeginContext(48, 14, true);
                WriteLiteral("\r\n\r\n\r\n    <h1>");
                EndContext();
                BeginContext(63, 19, false);
#line 10 "C:\Users\vikto\source\repos\MVC\Exercise\ASP.NET.WEB.API.Exercise_PartialViews\ASP.NET.WEB.API.Exercise_PartialViews\Views\RentACar\Index.cshtml"
   Write(ViewData["Heading"]);

#line default
#line hidden
                EndContext();
                BeginContext(82, 15, true);
                WriteLiteral("</h1>\r\n    <h2>");
                EndContext();
                BeginContext(98, 13, false);
#line 11 "C:\Users\vikto\source\repos\MVC\Exercise\ASP.NET.WEB.API.Exercise_PartialViews\ASP.NET.WEB.API.Exercise_PartialViews\Views\RentACar\Index.cshtml"
   Write(ViewBag.Title);

#line default
#line hidden
                EndContext();
                BeginContext(111, 204, true);
                WriteLiteral("</h2>\r\n    <div class=\"row\">\r\n        <div class=\"row row-cols-2 row-cols-md-2\">\r\n            <div class=\"col-6 col-sm-4\">\r\n                <div class=\"col mb-4\">\r\n                    <div class=\"card\">\r\n");
                EndContext();
#line 17 "C:\Users\vikto\source\repos\MVC\Exercise\ASP.NET.WEB.API.Exercise_PartialViews\ASP.NET.WEB.API.Exercise_PartialViews\Views\RentACar\Index.cshtml"
                         for (int i = 0; i < Model.Count; i++)
                        {

#line default
#line hidden
                BeginContext(406, 32, true);
                WriteLiteral("                            <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 438, "\"", 460, 1);
#line 19 "C:\Users\vikto\source\repos\MVC\Exercise\ASP.NET.WEB.API.Exercise_PartialViews\ASP.NET.WEB.API.Exercise_PartialViews\Views\RentACar\Index.cshtml"
WriteAttributeValue("", 444, Model[0].ImgUrl, 444, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(461, 142, true);
                WriteLiteral(" class=\"card-img-top\" alt=\"...\">\r\n                            <div class=\"card-body\">\r\n                                <h5 class=\"card-title\">");
                EndContext();
                BeginContext(604, 20, false);
#line 21 "C:\Users\vikto\source\repos\MVC\Exercise\ASP.NET.WEB.API.Exercise_PartialViews\ASP.NET.WEB.API.Exercise_PartialViews\Views\RentACar\Index.cshtml"
                                                  Write(Model[0].VehicleKind);

#line default
#line hidden
                EndContext();
                BeginContext(624, 9, true);
                WriteLiteral(" - Mark: ");
                EndContext();
                BeginContext(634, 13, false);
#line 21 "C:\Users\vikto\source\repos\MVC\Exercise\ASP.NET.WEB.API.Exercise_PartialViews\ASP.NET.WEB.API.Exercise_PartialViews\Views\RentACar\Index.cshtml"
                                                                                Write(Model[0].Type);

#line default
#line hidden
                EndContext();
                BeginContext(647, 104, true);
                WriteLiteral("</h5>\r\n                                <p class=\"card-text\">\r\n                                    TYPE: ");
                EndContext();
                BeginContext(752, 13, false);
#line 23 "C:\Users\vikto\source\repos\MVC\Exercise\ASP.NET.WEB.API.Exercise_PartialViews\ASP.NET.WEB.API.Exercise_PartialViews\Views\RentACar\Index.cshtml"
                                     Write(Model[0].Mark);

#line default
#line hidden
                EndContext();
                BeginContext(765, 11, true);
                WriteLiteral("  | COLOR: ");
                EndContext();
                BeginContext(777, 14, false);
#line 23 "C:\Users\vikto\source\repos\MVC\Exercise\ASP.NET.WEB.API.Exercise_PartialViews\ASP.NET.WEB.API.Exercise_PartialViews\Views\RentACar\Index.cshtml"
                                                              Write(Model[0].Color);

#line default
#line hidden
                EndContext();
                BeginContext(791, 11, true);
                WriteLiteral(" |  PRICE: ");
                EndContext();
                BeginContext(803, 14, false);
#line 23 "C:\Users\vikto\source\repos\MVC\Exercise\ASP.NET.WEB.API.Exercise_PartialViews\ASP.NET.WEB.API.Exercise_PartialViews\Views\RentACar\Index.cshtml"
                                                                                        Write(Model[0].Price);

#line default
#line hidden
                EndContext();
                BeginContext(817, 3, true);
                WriteLiteral(" - ");
                EndContext();
                BeginContext(821, 17, false);
#line 23 "C:\Users\vikto\source\repos\MVC\Exercise\ASP.NET.WEB.API.Exercise_PartialViews\ASP.NET.WEB.API.Exercise_PartialViews\Views\RentACar\Index.cshtml"
                                                                                                          Write(Model[0].Currency);

#line default
#line hidden
                EndContext();
                BeginContext(838, 1483, true);
                WriteLiteral(@" per day.
                                    <svg width=""1em"" height=""1em"" viewBox=""0 0 16 16"" class=""bi bi-calendar2-day-fill"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
                                        <path fill-rule=""evenodd"" d=""M3.5 0a.5.5 0 0 1 .5.5V1h8V.5a.5.5 0 0 1 1 0V1h1a2 2 0 0 1 2 2v11a2 2 0 0 1-2 2H2a2 2 0 0 1-2-2V3a2 2 0 0 1 2-2h1V.5a.5.5 0 0 1 .5-.5zM2 3.5c0-.276.244-.5.545-.5h10.91c.3 0 .545.224.545.5v1c0 .276-.244.5-.546.5H2.545C2.245 5 2 4.776 2 4.5v-1zm9.215 4.355a.425.425 0 0 1-.43-.425c0-.242.192-.43.43-.43a.428.428 0 1 1 0 .855zm.336.563v4.105h-.672V8.418h.672zm-6.867 4.105v-2.3h2.261v-.61H4.684V7.801h2.464v-.61H4v5.332h.684zm3.296 0h.676V9.98c0-.554.227-1.007.953-1.007.125 0 .258.004.329.015v-.613a1.806 1.806 0 0 0-.254-.02c-.582 0-.891.32-1.012.567h-.02v-.504H7.98v4.105z"" />
                                    </svg>
                                    <br />
                                    You take the car with full tank. The duration of the contract is i");
                WriteLiteral(@"n days and must return in last dey in time
                                    ex. if you take at time is 02:30 return on lust day 02:30.
                                    <br />
                                    If costumer want continue, he/she must call minimum 1 day.
                                    Everything except factory damage, customer pay. Have a nice trip.

                                </p>
                            </div>
");
                EndContext();
#line 36 "C:\Users\vikto\source\repos\MVC\Exercise\ASP.NET.WEB.API.Exercise_PartialViews\ASP.NET.WEB.API.Exercise_PartialViews\Views\RentACar\Index.cshtml"
                            break;
                        }

#line default
#line hidden
                BeginContext(2384, 194, true);
                WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-6 col-sm-4\">\r\n                <div class=\"col mb-4\">\r\n                    <div class=\"card\">\r\n");
                EndContext();
#line 44 "C:\Users\vikto\source\repos\MVC\Exercise\ASP.NET.WEB.API.Exercise_PartialViews\ASP.NET.WEB.API.Exercise_PartialViews\Views\RentACar\Index.cshtml"
                         for (int i = 0; i < Model.Count; i++)
                        {

#line default
#line hidden
                BeginContext(2669, 32, true);
                WriteLiteral("                            <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 2701, "\"", 2723, 1);
#line 46 "C:\Users\vikto\source\repos\MVC\Exercise\ASP.NET.WEB.API.Exercise_PartialViews\ASP.NET.WEB.API.Exercise_PartialViews\Views\RentACar\Index.cshtml"
WriteAttributeValue("", 2707, Model[3].ImgUrl, 2707, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2724, 142, true);
                WriteLiteral(" class=\"card-img-top\" alt=\"...\">\r\n                            <div class=\"card-body\">\r\n                                <h5 class=\"card-title\">");
                EndContext();
                BeginContext(2867, 20, false);
#line 48 "C:\Users\vikto\source\repos\MVC\Exercise\ASP.NET.WEB.API.Exercise_PartialViews\ASP.NET.WEB.API.Exercise_PartialViews\Views\RentACar\Index.cshtml"
                                                  Write(Model[3].VehicleKind);

#line default
#line hidden
                EndContext();
                BeginContext(2887, 9, true);
                WriteLiteral(" - Mark: ");
                EndContext();
                BeginContext(2897, 13, false);
#line 48 "C:\Users\vikto\source\repos\MVC\Exercise\ASP.NET.WEB.API.Exercise_PartialViews\ASP.NET.WEB.API.Exercise_PartialViews\Views\RentACar\Index.cshtml"
                                                                                Write(Model[3].Type);

#line default
#line hidden
                EndContext();
                BeginContext(2910, 104, true);
                WriteLiteral("</h5>\r\n                                <p class=\"card-text\">\r\n                                    TYPE: ");
                EndContext();
                BeginContext(3015, 13, false);
#line 50 "C:\Users\vikto\source\repos\MVC\Exercise\ASP.NET.WEB.API.Exercise_PartialViews\ASP.NET.WEB.API.Exercise_PartialViews\Views\RentACar\Index.cshtml"
                                     Write(Model[3].Mark);

#line default
#line hidden
                EndContext();
                BeginContext(3028, 11, true);
                WriteLiteral("  | COLOR: ");
                EndContext();
                BeginContext(3040, 14, false);
#line 50 "C:\Users\vikto\source\repos\MVC\Exercise\ASP.NET.WEB.API.Exercise_PartialViews\ASP.NET.WEB.API.Exercise_PartialViews\Views\RentACar\Index.cshtml"
                                                              Write(Model[3].Color);

#line default
#line hidden
                EndContext();
                BeginContext(3054, 11, true);
                WriteLiteral(" |  PRICE: ");
                EndContext();
                BeginContext(3066, 14, false);
#line 50 "C:\Users\vikto\source\repos\MVC\Exercise\ASP.NET.WEB.API.Exercise_PartialViews\ASP.NET.WEB.API.Exercise_PartialViews\Views\RentACar\Index.cshtml"
                                                                                        Write(Model[3].Price);

#line default
#line hidden
                EndContext();
                BeginContext(3080, 3, true);
                WriteLiteral(" - ");
                EndContext();
                BeginContext(3084, 17, false);
#line 50 "C:\Users\vikto\source\repos\MVC\Exercise\ASP.NET.WEB.API.Exercise_PartialViews\ASP.NET.WEB.API.Exercise_PartialViews\Views\RentACar\Index.cshtml"
                                                                                                          Write(Model[3].Currency);

#line default
#line hidden
                EndContext();
                BeginContext(3101, 1481, true);
                WriteLiteral(@" per day.
                                    <svg width=""1em"" height=""1em"" viewBox=""0 0 16 16"" class=""bi bi-calendar2-day-fill"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
                                        <path fill-rule=""evenodd"" d=""M3.5 0a.5.5 0 0 1 .5.5V1h8V.5a.5.5 0 0 1 1 0V1h1a2 2 0 0 1 2 2v11a2 2 0 0 1-2 2H2a2 2 0 0 1-2-2V3a2 2 0 0 1 2-2h1V.5a.5.5 0 0 1 .5-.5zM2 3.5c0-.276.244-.5.545-.5h10.91c.3 0 .545.224.545.5v1c0 .276-.244.5-.546.5H2.545C2.245 5 2 4.776 2 4.5v-1zm9.215 4.355a.425.425 0 0 1-.43-.425c0-.242.192-.43.43-.43a.428.428 0 1 1 0 .855zm.336.563v4.105h-.672V8.418h.672zm-6.867 4.105v-2.3h2.261v-.61H4.684V7.801h2.464v-.61H4v5.332h.684zm3.296 0h.676V9.98c0-.554.227-1.007.953-1.007.125 0 .258.004.329.015v-.613a1.806 1.806 0 0 0-.254-.02c-.582 0-.891.32-1.012.567h-.02v-.504H7.98v4.105z"" />
                                    </svg>
                                    <br />
                                    You take the car with full tank. The duration of the contract is i");
                WriteLiteral(@"n days and must return in last dey in time
                                    ex. if you take at time is 02:30 return on lust day 02:30.
                                    <br />
                                    If costumer want continue, he/she must call minimum 1 day.
                                    Everything except factory damage, customer pay. Have a nice trip.
                                </p>
                            </div>
");
                EndContext();
#line 62 "C:\Users\vikto\source\repos\MVC\Exercise\ASP.NET.WEB.API.Exercise_PartialViews\ASP.NET.WEB.API.Exercise_PartialViews\Views\RentACar\Index.cshtml"
                            break;
                        }

#line default
#line hidden
                BeginContext(4645, 194, true);
                WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-6 col-sm-4\">\r\n                <div class=\"col mb-4\">\r\n                    <div class=\"card\">\r\n");
                EndContext();
#line 70 "C:\Users\vikto\source\repos\MVC\Exercise\ASP.NET.WEB.API.Exercise_PartialViews\ASP.NET.WEB.API.Exercise_PartialViews\Views\RentACar\Index.cshtml"
                         for (int i = 0; i < Model.Count; i++)
                        {

#line default
#line hidden
                BeginContext(4930, 32, true);
                WriteLiteral("                            <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 4962, "\"", 4984, 1);
#line 72 "C:\Users\vikto\source\repos\MVC\Exercise\ASP.NET.WEB.API.Exercise_PartialViews\ASP.NET.WEB.API.Exercise_PartialViews\Views\RentACar\Index.cshtml"
WriteAttributeValue("", 4968, Model[6].ImgUrl, 4968, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4985, 142, true);
                WriteLiteral(" class=\"card-img-top\" alt=\"...\">\r\n                            <div class=\"card-body\">\r\n                                <h5 class=\"card-title\">");
                EndContext();
                BeginContext(5128, 20, false);
#line 74 "C:\Users\vikto\source\repos\MVC\Exercise\ASP.NET.WEB.API.Exercise_PartialViews\ASP.NET.WEB.API.Exercise_PartialViews\Views\RentACar\Index.cshtml"
                                                  Write(Model[6].VehicleKind);

#line default
#line hidden
                EndContext();
                BeginContext(5148, 9, true);
                WriteLiteral(" - Mark: ");
                EndContext();
                BeginContext(5158, 13, false);
#line 74 "C:\Users\vikto\source\repos\MVC\Exercise\ASP.NET.WEB.API.Exercise_PartialViews\ASP.NET.WEB.API.Exercise_PartialViews\Views\RentACar\Index.cshtml"
                                                                                Write(Model[6].Type);

#line default
#line hidden
                EndContext();
                BeginContext(5171, 104, true);
                WriteLiteral("</h5>\r\n                                <p class=\"card-text\">\r\n                                    TYPE: ");
                EndContext();
                BeginContext(5276, 13, false);
#line 76 "C:\Users\vikto\source\repos\MVC\Exercise\ASP.NET.WEB.API.Exercise_PartialViews\ASP.NET.WEB.API.Exercise_PartialViews\Views\RentACar\Index.cshtml"
                                     Write(Model[6].Mark);

#line default
#line hidden
                EndContext();
                BeginContext(5289, 11, true);
                WriteLiteral("  | COLOR: ");
                EndContext();
                BeginContext(5301, 14, false);
#line 76 "C:\Users\vikto\source\repos\MVC\Exercise\ASP.NET.WEB.API.Exercise_PartialViews\ASP.NET.WEB.API.Exercise_PartialViews\Views\RentACar\Index.cshtml"
                                                              Write(Model[6].Color);

#line default
#line hidden
                EndContext();
                BeginContext(5315, 11, true);
                WriteLiteral(" |  PRICE: ");
                EndContext();
                BeginContext(5327, 14, false);
#line 76 "C:\Users\vikto\source\repos\MVC\Exercise\ASP.NET.WEB.API.Exercise_PartialViews\ASP.NET.WEB.API.Exercise_PartialViews\Views\RentACar\Index.cshtml"
                                                                                        Write(Model[6].Price);

#line default
#line hidden
                EndContext();
                BeginContext(5341, 3, true);
                WriteLiteral(" - ");
                EndContext();
                BeginContext(5345, 17, false);
#line 76 "C:\Users\vikto\source\repos\MVC\Exercise\ASP.NET.WEB.API.Exercise_PartialViews\ASP.NET.WEB.API.Exercise_PartialViews\Views\RentACar\Index.cshtml"
                                                                                                          Write(Model[6].Currency);

#line default
#line hidden
                EndContext();
                BeginContext(5362, 1485, true);
                WriteLiteral(@" per day.
                                    <svg width=""1em"" height=""1em"" viewBox=""0 0 16 16"" class=""bi bi-calendar2-day-fill"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
                                        <path fill-rule=""evenodd"" d=""M3.5 0a.5.5 0 0 1 .5.5V1h8V.5a.5.5 0 0 1 1 0V1h1a2 2 0 0 1 2 2v11a2 2 0 0 1-2 2H2a2 2 0 0 1-2-2V3a2 2 0 0 1 2-2h1V.5a.5.5 0 0 1 .5-.5zM2 3.5c0-.276.244-.5.545-.5h10.91c.3 0 .545.224.545.5v1c0 .276-.244.5-.546.5H2.545C2.245 5 2 4.776 2 4.5v-1zm9.215 4.355a.425.425 0 0 1-.43-.425c0-.242.192-.43.43-.43a.428.428 0 1 1 0 .855zm.336.563v4.105h-.672V8.418h.672zm-6.867 4.105v-2.3h2.261v-.61H4.684V7.801h2.464v-.61H4v5.332h.684zm3.296 0h.676V9.98c0-.554.227-1.007.953-1.007.125 0 .258.004.329.015v-.613a1.806 1.806 0 0 0-.254-.02c-.582 0-.891.32-1.012.567h-.02v-.504H7.98v4.105z"" />
                                    </svg>
                                    <br />
                                    You take the scooter with full tank. The duration of the contract ");
                WriteLiteral(@"is in days and must return in last dey in time
                                    ex. if you take at time is 02:30 return on lust day 02:30.
                                    <br />
                                    If costumer want continue, he/she must call minimum 1 day.
                                    Everything except factory damage, customer pay. Have a nice trip.
                                </p>
                            </div>
");
                EndContext();
#line 88 "C:\Users\vikto\source\repos\MVC\Exercise\ASP.NET.WEB.API.Exercise_PartialViews\ASP.NET.WEB.API.Exercise_PartialViews\Views\RentACar\Index.cshtml"
                            break;
                        }

#line default
#line hidden
                BeginContext(6910, 194, true);
                WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-6 col-sm-4\">\r\n                <div class=\"col mb-4\">\r\n                    <div class=\"card\">\r\n");
                EndContext();
#line 96 "C:\Users\vikto\source\repos\MVC\Exercise\ASP.NET.WEB.API.Exercise_PartialViews\ASP.NET.WEB.API.Exercise_PartialViews\Views\RentACar\Index.cshtml"
                         for (int i = 0; i < Model.Count; i++)
                        {

#line default
#line hidden
                BeginContext(7195, 32, true);
                WriteLiteral("                            <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 7227, "\"", 7250, 1);
#line 98 "C:\Users\vikto\source\repos\MVC\Exercise\ASP.NET.WEB.API.Exercise_PartialViews\ASP.NET.WEB.API.Exercise_PartialViews\Views\RentACar\Index.cshtml"
WriteAttributeValue("", 7233, Model[10].ImgUrl, 7233, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(7251, 142, true);
                WriteLiteral(" class=\"card-img-top\" alt=\"...\">\r\n                            <div class=\"card-body\">\r\n                                <h5 class=\"card-title\">");
                EndContext();
                BeginContext(7394, 21, false);
#line 100 "C:\Users\vikto\source\repos\MVC\Exercise\ASP.NET.WEB.API.Exercise_PartialViews\ASP.NET.WEB.API.Exercise_PartialViews\Views\RentACar\Index.cshtml"
                                                  Write(Model[10].VehicleKind);

#line default
#line hidden
                EndContext();
                BeginContext(7415, 9, true);
                WriteLiteral(" - Mark: ");
                EndContext();
                BeginContext(7425, 14, false);
#line 100 "C:\Users\vikto\source\repos\MVC\Exercise\ASP.NET.WEB.API.Exercise_PartialViews\ASP.NET.WEB.API.Exercise_PartialViews\Views\RentACar\Index.cshtml"
                                                                                 Write(Model[10].Type);

#line default
#line hidden
                EndContext();
                BeginContext(7439, 104, true);
                WriteLiteral("</h5>\r\n                                <p class=\"card-text\">\r\n                                    TYPE: ");
                EndContext();
                BeginContext(7544, 14, false);
#line 102 "C:\Users\vikto\source\repos\MVC\Exercise\ASP.NET.WEB.API.Exercise_PartialViews\ASP.NET.WEB.API.Exercise_PartialViews\Views\RentACar\Index.cshtml"
                                     Write(Model[10].Mark);

#line default
#line hidden
                EndContext();
                BeginContext(7558, 11, true);
                WriteLiteral("  | COLOR: ");
                EndContext();
                BeginContext(7570, 15, false);
#line 102 "C:\Users\vikto\source\repos\MVC\Exercise\ASP.NET.WEB.API.Exercise_PartialViews\ASP.NET.WEB.API.Exercise_PartialViews\Views\RentACar\Index.cshtml"
                                                               Write(Model[10].Color);

#line default
#line hidden
                EndContext();
                BeginContext(7585, 11, true);
                WriteLiteral(" |  PRICE: ");
                EndContext();
                BeginContext(7597, 15, false);
#line 102 "C:\Users\vikto\source\repos\MVC\Exercise\ASP.NET.WEB.API.Exercise_PartialViews\ASP.NET.WEB.API.Exercise_PartialViews\Views\RentACar\Index.cshtml"
                                                                                          Write(Model[10].Price);

#line default
#line hidden
                EndContext();
                BeginContext(7612, 3, true);
                WriteLiteral(" - ");
                EndContext();
                BeginContext(7616, 18, false);
#line 102 "C:\Users\vikto\source\repos\MVC\Exercise\ASP.NET.WEB.API.Exercise_PartialViews\ASP.NET.WEB.API.Exercise_PartialViews\Views\RentACar\Index.cshtml"
                                                                                                             Write(Model[10].Currency);

#line default
#line hidden
                EndContext();
                BeginContext(7634, 1448, true);
                WriteLiteral(@" per day.
                                    <svg width=""1em"" height=""1em"" viewBox=""0 0 16 16"" class=""bi bi-calendar2-day-fill"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
                                        <path fill-rule=""evenodd"" d=""M3.5 0a.5.5 0 0 1 .5.5V1h8V.5a.5.5 0 0 1 1 0V1h1a2 2 0 0 1 2 2v11a2 2 0 0 1-2 2H2a2 2 0 0 1-2-2V3a2 2 0 0 1 2-2h1V.5a.5.5 0 0 1 .5-.5zM2 3.5c0-.276.244-.5.545-.5h10.91c.3 0 .545.224.545.5v1c0 .276-.244.5-.546.5H2.545C2.245 5 2 4.776 2 4.5v-1zm9.215 4.355a.425.425 0 0 1-.43-.425c0-.242.192-.43.43-.43a.428.428 0 1 1 0 .855zm.336.563v4.105h-.672V8.418h.672zm-6.867 4.105v-2.3h2.261v-.61H4.684V7.801h2.464v-.61H4v5.332h.684zm3.296 0h.676V9.98c0-.554.227-1.007.953-1.007.125 0 .258.004.329.015v-.613a1.806 1.806 0 0 0-.254-.02c-.582 0-.891.32-1.012.567h-.02v-.504H7.98v4.105z"" />
                                    </svg>
                                    <br />
                                    The duration of the contract is in days and must return in last de");
                WriteLiteral(@"y in time
                                    ex. if you take at time is 02:30 return on lust day 02:30.
                                    <br />
                                    If costumer want continue, he/she must call minimum 1 day.
                                    Everything except factory damage, customer pay. Have a nice trip.
                                </p>
                            </div>
");
                EndContext();
#line 114 "C:\Users\vikto\source\repos\MVC\Exercise\ASP.NET.WEB.API.Exercise_PartialViews\ASP.NET.WEB.API.Exercise_PartialViews\Views\RentACar\Index.cshtml"
                            break;
                        }

#line default
#line hidden
                BeginContext(9145, 1427, true);
                WriteLiteral(@"                    </div>
                </div>
                
                </div>
            </div>
        <div class=""backImg"">
            <img class=""carsImgBg"" src=""http://pngimg.com/uploads/acura/acura_PNG124.png"" alt=""""/>
            <h3>TOUR DE MACEDONIA</h3>
            <p class=""wish"">Your wish is our command
                <svg width=""1em"" height=""1em"" viewBox=""0 0 16 16"" class=""bi bi-emoji-sunglasses"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"">
                    <path fill-rule=""evenodd"" d=""M8 15A7 7 0 1 0 8 1a7 7 0 0 0 0 14zm0 1A8 8 0 1 0 8 0a8 8 0 0 0 0 16z"" />
                    <path fill-rule=""evenodd"" d=""M4.285 9.567a.5.5 0 0 1 .683.183A3.498 3.498 0 0 0 8 11.5a3.498 3.498 0 0 0 3.032-1.75.5.5 0 1 1 .866.5A4.498 4.498 0 0 1 8 12.5a4.498 4.498 0 0 1-3.898-2.25.5.5 0 0 1 .183-.683zM6.5 6.497V6.5h-1c0-.568.447-.947.862-1.154C6.807 5.123 7.387 5 8 5s1.193.123 1.638.346c.415.207.862.586.862 1.154h-1v-.003l-.003-.01a.213.213 0 0 0-.036-.053.86.86 0 0 0-.27-.194C");
                WriteLiteral(@"8.91 6.1 8.49 6 8 6c-.491 0-.912.1-1.19.24a.86.86 0 0 0-.271.194.213.213 0 0 0-.036.054l-.003.01z"" />
                    <path d=""M2.31 5.243A1 1 0 0 1 3.28 4H6a1 1 0 0 1 1 1v1a2 2 0 0 1-2 2h-.438a2 2 0 0 1-1.94-1.515L2.31 5.243zM9 5a1 1 0 0 1 1-1h2.72a1 1 0 0 1 .97 1.243l-.311 1.242A2 2 0 0 1 11.439 8H11a2 2 0 0 1-2-2V5z"" />
                </svg>
            </p>
        </div>

</div>


");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(10598, 1734, true);
            WriteLiteral(@"
<style>
    body {
        background-image: url(https://cdn.pixabay.com/photo/2017/09/14/11/06/water-2748638_1280.png);            
        background-color: aqua;
        background-size: cover;
        background-repeat: repeat-x;
        background-position-x: center;
    }
    h1{        
        font-family:'Viner Hand ITC';
        font-size: 6rem;
        text-align:center;
    }
    h2{
        font-family:'Niagara Solid';
        text-align:center;
        letter-spacing:4px;
        font-size:5rem;
        color:darkmagenta;
    }
    .col{
        width:300px;
    }
    .card-img-top{
       
        width:300px;
        border:20px solid black;
        border-radius:40px;
        margin:20px;
        
    }
    .card-text{
        font-family:'Franklin Gothic Book';
        font-size:16px;
        color:darkblue;
        background-color:rgba(107, 0, 130, 0.22);
        
        border:2px double black;
        border-bottom-right-radius:20px;

    }
   ");
            WriteLiteral(@" h5 {
        font-family:'Old Antic';
        font-size: 26px;
        color: darkred;
        text-shadow: 2px 2px 2px #FF0000;
        letter-spacing:2px;
        font-weight:700;
    }
    .backImg {
        position: absolute;
        width: 700px;
        height: 400px;
        bottom: -500px;
        right: 200px;   
        text-align:center;
    }
    .carsImgBg{
        width:600px;
    }
    h3{
        font-family: 'Viner Hand ITC';
        font-size:25PX;
        text-decoration:underline;
        font-weight:700;
        letter-spacing:2px;
        color:saddlebrown;
    }
    .wish{
        font-stretch:semi-expanded;
        font-size:16px;
    }
</style>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<VehiclesVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
