#pragma checksum "C:\Users\tamil\Downloads\FoodDonationWebApp-master\FoodDonationWebApp-master\FoodDonation\Views\Profile\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7755a3af6d12c692b333f8bdcea63ad7b085c9f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_Index), @"mvc.1.0.view", @"/Views/Profile/Index.cshtml")]
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
#line 1 "C:\Users\tamil\Downloads\FoodDonationWebApp-master\FoodDonationWebApp-master\FoodDonation\Views\_ViewImports.cshtml"
using FoodDonation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tamil\Downloads\FoodDonationWebApp-master\FoodDonationWebApp-master\FoodDonation\Views\_ViewImports.cshtml"
using FoodDonation.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tamil\Downloads\FoodDonationWebApp-master\FoodDonationWebApp-master\FoodDonation\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7755a3af6d12c692b333f8bdcea63ad7b085c9f3", @"/Views/Profile/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6604df79d82dd70895467bfb89f080d83d6d3ba", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Profile_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FoodDonation.ViewModels.ProfileViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", new global::Microsoft.AspNetCore.Html.HtmlString("btnAddMore"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Manage/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Manage"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Donors", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DonationDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Charities", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\tamil\Downloads\FoodDonationWebApp-master\FoodDonationWebApp-master\FoodDonation\Views\Profile\Index.cshtml"
  
    ViewData["Title"] = "Profile";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h5>Profile</h5>\n <div class=\"container emp-profile\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7755a3af6d12c692b333f8bdcea63ad7b085c9f37353", async() => {
                WriteLiteral(@"
            <div class=""row"">
                <div class=""col-md-4"">
                    <div class=""profile-img"">
                       
                    </div>
                </div>
                <div class=""col-md-6"">
                    <div class=""profile-head"">
                        <h5>
                            ");
#nullable restore
#line 19 "C:\Users\tamil\Downloads\FoodDonationWebApp-master\FoodDonationWebApp-master\FoodDonation\Views\Profile\Index.cshtml"
                       Write(Html.DisplayFor(model => model.Fullname));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        </h5>\n                        <p>\n                            ");
#nullable restore
#line 22 "C:\Users\tamil\Downloads\FoodDonationWebApp-master\FoodDonationWebApp-master\FoodDonation\Views\Profile\Index.cshtml"
                       Write(Html.DisplayFor(model => model.UserRole));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        </p>    \n                        <h6>\n                            ");
#nullable restore
#line 25 "C:\Users\tamil\Downloads\FoodDonationWebApp-master\FoodDonationWebApp-master\FoodDonation\Views\Profile\Index.cshtml"
                       Write(Html.DisplayFor(model => model.OrganisationName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                        </h6>                       \n                        <p class=\"proile-rating\">Number of Donations: <span> ");
#nullable restore
#line 27 "C:\Users\tamil\Downloads\FoodDonationWebApp-master\FoodDonationWebApp-master\FoodDonation\Views\Profile\Index.cshtml"
                                                                        Write(Html.DisplayFor(model => model.NumberofDonations));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</span></p>
                        <ul class=""nav nav-tabs"" id=""myTab"" role=""tablist"">
                            <li class=""nav-item"">
                                <a class=""nav-link active"" id=""home-tab"" data-toggle=""tab"" href=""#home"" role=""tab"" aria-controls=""home"" aria-selected=""true"">About</a>
                            </li>
                            <li class=""nav-item"">
                                <a class=""nav-link"" id=""profile-tab"" data-toggle=""tab"" href=""#profile"" role=""tab"" aria-controls=""profile"" aria-selected=""false"">Donations</a>
                            </li>
                        </ul>
                    </div>
                </div>
                <div class=""col-md-2"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7755a3af6d12c692b333f8bdcea63ad7b085c9f310337", async() => {
                    WriteLiteral("Edit Profile");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                </div>
            </div>
            <div class=""row"">
                <div class=""col-md-4"">
                    <div class=""profile-work"">
                        <p><Strong>Contact Details</Strong></p>
                        <p>Phone Number:<a");
                BeginWriteAttribute("href", " href=\"", 2125, "\"", 2152, 1);
#nullable restore
#line 46 "C:\Users\tamil\Downloads\FoodDonationWebApp-master\FoodDonationWebApp-master\FoodDonation\Views\Profile\Index.cshtml"
WriteAttributeValue("", 2132, Model.ContactNumber, 2132, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 46 "C:\Users\tamil\Downloads\FoodDonationWebApp-master\FoodDonationWebApp-master\FoodDonation\Views\Profile\Index.cshtml"
                                                                  Write(Model.ContactNumber);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></p><br />\n\n                        <p>WhatsApp:<a");
                BeginWriteAttribute("href", " href=\'", 2228, "\'", 2264, 2);
                WriteAttributeValue("", 2235, "https://wa.me/", 2235, 14, true);
#nullable restore
#line 48 "C:\Users\tamil\Downloads\FoodDonationWebApp-master\FoodDonationWebApp-master\FoodDonation\Views\Profile\Index.cshtml"
WriteAttributeValue("", 2249, Model.WhatsApp, 2249, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" target=\'_blank\'><i class=\"fa fa-whatsapp\"></i>");
#nullable restore
#line 48 "C:\Users\tamil\Downloads\FoodDonationWebApp-master\FoodDonationWebApp-master\FoodDonation\Views\Profile\Index.cshtml"
                                                                                                                     Write(Html.DisplayFor(model => model.WhatsApp));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</a></p>
                    </div>
                </div>
                <div class=""col-md-8"">
                    <div class=""tab-content profile-tab"" id=""myTabContent"">
                        <div class=""tab-pane fade show active"" id=""home"" role=""tabpanel"" aria-labelledby=""home-tab"">
                            <div class=""row"">
                                <div class=""col-md-6"">
                                    <label>Name</label>
                                </div>
                                <div class=""col-md-6"">
                                    <p>");
#nullable restore
#line 59 "C:\Users\tamil\Downloads\FoodDonationWebApp-master\FoodDonationWebApp-master\FoodDonation\Views\Profile\Index.cshtml"
                                  Write(Model.Fullname);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-md-6"">
                                    <label>Email</label>
                                </div>
                                <div class=""col-md-6"">
                                    <p>");
#nullable restore
#line 67 "C:\Users\tamil\Downloads\FoodDonationWebApp-master\FoodDonationWebApp-master\FoodDonation\Views\Profile\Index.cshtml"
                                  Write(ViewBag.userMail);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-md-6"">
                                    <label>Address</label>
                                </div>
                                <div class=""col-md-6"">
                                    <p>");
#nullable restore
#line 75 "C:\Users\tamil\Downloads\FoodDonationWebApp-master\FoodDonationWebApp-master\FoodDonation\Views\Profile\Index.cshtml"
                                  Write(Model.Address);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                                </div>
                            </div>
                            <div class=""row"">
                                <div class=""col-md-6"">
                                    <label>About Me</label>
                                </div>
                                <div class=""col-md-6"">
                                    <p>");
#nullable restore
#line 83 "C:\Users\tamil\Downloads\FoodDonationWebApp-master\FoodDonationWebApp-master\FoodDonation\Views\Profile\Index.cshtml"
                                  Write(Model.About);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</p>
                                </div>
                            </div>
                        </div>
                        <div class=""tab-pane fade"" id=""profile"" role=""tabpanel"" aria-labelledby=""profile-tab"">
                            <table class=""table"">
                                <thead>
                                    <tr>
                                        <th>
                                            Title:
                                        </th>

");
#nullable restore
#line 95 "C:\Users\tamil\Downloads\FoodDonationWebApp-master\FoodDonationWebApp-master\FoodDonation\Views\Profile\Index.cshtml"
                                         if (@Model.UserRole == "Donor")
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                         <th>\n                                            Charity:\n                                         </th>\n");
#nullable restore
#line 100 "C:\Users\tamil\Downloads\FoodDonationWebApp-master\FoodDonationWebApp-master\FoodDonation\Views\Profile\Index.cshtml"
                                         }
                                        else
                                         {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <th>\n                                            Donor:\n                                        </th>\n");
#nullable restore
#line 106 "C:\Users\tamil\Downloads\FoodDonationWebApp-master\FoodDonationWebApp-master\FoodDonation\Views\Profile\Index.cshtml"
                                         }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                            <th>
                                                Donated on:
                                            </th>
                                            <th>
                                                Action
                                            </th>
                                        </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 116 "C:\Users\tamil\Downloads\FoodDonationWebApp-master\FoodDonationWebApp-master\FoodDonation\Views\Profile\Index.cshtml"
                                     if (ViewBag.userstatus == true)
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 118 "C:\Users\tamil\Downloads\FoodDonationWebApp-master\FoodDonationWebApp-master\FoodDonation\Views\Profile\Index.cshtml"
                                         foreach (var item in Model.Donations)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <tr>\n                                        <td>\n                                            ");
#nullable restore
#line 122 "C:\Users\tamil\Downloads\FoodDonationWebApp-master\FoodDonationWebApp-master\FoodDonation\Views\Profile\Index.cshtml"
                                       Write(Html.DisplayFor(modelItem => item.postTitle));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                        </td>\n\n");
#nullable restore
#line 125 "C:\Users\tamil\Downloads\FoodDonationWebApp-master\FoodDonationWebApp-master\FoodDonation\Views\Profile\Index.cshtml"
                                         if (@Model.UserRole == "Donor")
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <td>\n                                               ");
#nullable restore
#line 128 "C:\Users\tamil\Downloads\FoodDonationWebApp-master\FoodDonationWebApp-master\FoodDonation\Views\Profile\Index.cshtml"
                                          Write(item.CharityName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                            </td>\n");
#nullable restore
#line 130 "C:\Users\tamil\Downloads\FoodDonationWebApp-master\FoodDonationWebApp-master\FoodDonation\Views\Profile\Index.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <td>\n                                        ");
#nullable restore
#line 134 "C:\Users\tamil\Downloads\FoodDonationWebApp-master\FoodDonationWebApp-master\FoodDonation\Views\Profile\Index.cshtml"
                                   Write(item.DonorName);

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                    </td>\n");
#nullable restore
#line 136 "C:\Users\tamil\Downloads\FoodDonationWebApp-master\FoodDonationWebApp-master\FoodDonation\Views\Profile\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <td>\n                                            <strong> </strong>");
#nullable restore
#line 138 "C:\Users\tamil\Downloads\FoodDonationWebApp-master\FoodDonationWebApp-master\FoodDonation\Views\Profile\Index.cshtml"
                                                         Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                        </td>\n");
#nullable restore
#line 140 "C:\Users\tamil\Downloads\FoodDonationWebApp-master\FoodDonationWebApp-master\FoodDonation\Views\Profile\Index.cshtml"
                                         if (@Model.UserRole == "Donor")
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <td>\n                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7755a3af6d12c692b333f8bdcea63ad7b085c9f323199", async() => {
                    WriteLiteral("Details");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 143 "C:\Users\tamil\Downloads\FoodDonationWebApp-master\FoodDonationWebApp-master\FoodDonation\Views\Profile\Index.cshtml"
                                                                                                          WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                            </td>\n");
#nullable restore
#line 145 "C:\Users\tamil\Downloads\FoodDonationWebApp-master\FoodDonationWebApp-master\FoodDonation\Views\Profile\Index.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            <td>\n                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7755a3af6d12c692b333f8bdcea63ad7b085c9f326362", async() => {
                    WriteLiteral("Details");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 149 "C:\Users\tamil\Downloads\FoodDonationWebApp-master\FoodDonationWebApp-master\FoodDonation\Views\Profile\Index.cshtml"
                                                                                                             WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n                                            </td>\n");
#nullable restore
#line 151 "C:\Users\tamil\Downloads\FoodDonationWebApp-master\FoodDonationWebApp-master\FoodDonation\Views\Profile\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                    </tr>\n");
#nullable restore
#line 154 "C:\Users\tamil\Downloads\FoodDonationWebApp-master\FoodDonationWebApp-master\FoodDonation\Views\Profile\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 154 "C:\Users\tamil\Downloads\FoodDonationWebApp-master\FoodDonationWebApp-master\FoodDonation\Views\Profile\Index.cshtml"
                                         
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    </tbody>\n                            </table>\n                        </div>\n                    </div>\n                </div>\n            </div>\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FoodDonation.ViewModels.ProfileViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
