#pragma checksum "F:\CFP\EmployeePayroll\EmployeePayrollBlazor\Pages\DeleteEmployee.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf0995dc300c90375b1e806d9adf05895e4c1e28"
// <auto-generated/>
#pragma warning disable 1591
namespace EmployeePayrollBlazor.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "F:\CFP\EmployeePayroll\EmployeePayrollBlazor\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\CFP\EmployeePayroll\EmployeePayrollBlazor\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\CFP\EmployeePayroll\EmployeePayrollBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\CFP\EmployeePayroll\EmployeePayrollBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\CFP\EmployeePayroll\EmployeePayrollBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\CFP\EmployeePayroll\EmployeePayrollBlazor\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\CFP\EmployeePayroll\EmployeePayrollBlazor\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\CFP\EmployeePayroll\EmployeePayrollBlazor\_Imports.razor"
using EmployeePayrollBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\CFP\EmployeePayroll\EmployeePayrollBlazor\_Imports.razor"
using EmployeePayrollBlazor.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\CFP\EmployeePayroll\EmployeePayrollBlazor\_Imports.razor"
using MatBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\CFP\EmployeePayroll\EmployeePayrollBlazor\Pages\DeleteEmployee.razor"
using EmployeePayrollModelLayer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\CFP\EmployeePayroll\EmployeePayrollBlazor\Pages\DeleteEmployee.razor"
using EmployeePayrollManagerLayer.Interface;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Delete/{Id}")]
    public partial class DeleteEmployee : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<header class=""header-content header"">
    <div class=""logo-content"">
        <img src=""../assets/EmpPayrollLogo.png"" alt=""logo"">
        <div>
            <span class=""emp-text"">employee</span><br>
            <span class=""emp-text emp-payroll"">payroll</span>
        </div>
    </div>
</header>

");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "form");
            __builder.AddMarkupContent(5, "\r\n        ");
            __builder.AddMarkupContent(6, "<h3>Are you sure you want to delete this?</h3>\r\n        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col");
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenElement(10, "div");
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.AddMarkupContent(12, "<label class=\"delete label\">Employee ID:</label>\r\n                ");
            __builder.OpenElement(13, "label");
            __builder.AddAttribute(14, "class", "delete value");
            __builder.AddContent(15, 
#nullable restore
#line 24 "F:\CFP\EmployeePayroll\EmployeePayrollBlazor\Pages\DeleteEmployee.razor"
                                             Emp.Id

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.OpenElement(18, "div");
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.AddMarkupContent(20, "<label class=\"delete label\">Name:</label>\r\n                ");
            __builder.OpenElement(21, "label");
            __builder.AddAttribute(22, "class", "delete value");
            __builder.AddContent(23, 
#nullable restore
#line 28 "F:\CFP\EmployeePayroll\EmployeePayrollBlazor\Pages\DeleteEmployee.razor"
                                             Emp.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n            ");
            __builder.OpenElement(26, "div");
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.AddMarkupContent(28, "<label class=\"delete label\">Profile Image:</label>\r\n                ");
            __builder.OpenElement(29, "img");
            __builder.AddAttribute(30, "class", "profileDelete");
            __builder.AddAttribute(31, "id", "img1");
            __builder.AddAttribute(32, "src", 
#nullable restore
#line 32 "F:\CFP\EmployeePayroll\EmployeePayrollBlazor\Pages\DeleteEmployee.razor"
                                                          Emp.Profile

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n            ");
            __builder.OpenElement(35, "div");
            __builder.AddMarkupContent(36, "\r\n                ");
            __builder.AddMarkupContent(37, "<label class=\"delete label\">Gender:</label>\r\n                ");
            __builder.OpenElement(38, "label");
            __builder.AddAttribute(39, "class", "delete value");
            __builder.AddContent(40, 
#nullable restore
#line 36 "F:\CFP\EmployeePayroll\EmployeePayrollBlazor\Pages\DeleteEmployee.razor"
                                             Emp.Gender

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n            ");
            __builder.OpenElement(43, "div");
            __builder.AddMarkupContent(44, "\r\n                ");
            __builder.AddMarkupContent(45, "<label class=\"delete label\">Department:</label>\r\n                ");
            __builder.OpenElement(46, "label");
            __builder.AddAttribute(47, "class", "delete value");
            __builder.AddContent(48, 
#nullable restore
#line 40 "F:\CFP\EmployeePayroll\EmployeePayrollBlazor\Pages\DeleteEmployee.razor"
                                             Emp.Department

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n            ");
            __builder.OpenElement(51, "div");
            __builder.AddMarkupContent(52, "\r\n                ");
            __builder.AddMarkupContent(53, "<label class=\"delete label\">Salary:</label>\r\n                ");
            __builder.OpenElement(54, "label");
            __builder.AddAttribute(55, "class", "delete value");
            __builder.AddContent(56, 
#nullable restore
#line 44 "F:\CFP\EmployeePayroll\EmployeePayrollBlazor\Pages\DeleteEmployee.razor"
                                             Emp.Salary

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n            ");
            __builder.OpenElement(59, "div");
            __builder.AddMarkupContent(60, "\r\n                ");
            __builder.AddMarkupContent(61, "<label class=\"delete label\">StartDate:</label>\r\n                ");
            __builder.OpenElement(62, "label");
            __builder.AddAttribute(63, "class", "delete value");
            __builder.AddContent(64, 
#nullable restore
#line 48 "F:\CFP\EmployeePayroll\EmployeePayrollBlazor\Pages\DeleteEmployee.razor"
                                             Emp.Date

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n            ");
            __builder.OpenElement(67, "div");
            __builder.AddMarkupContent(68, "\r\n                ");
            __builder.AddMarkupContent(69, "<label class=\"delete label\">Notes:</label>\r\n                ");
            __builder.OpenElement(70, "label");
            __builder.AddAttribute(71, "class", "delete value");
            __builder.AddContent(72, 
#nullable restore
#line 52 "F:\CFP\EmployeePayroll\EmployeePayrollBlazor\Pages\DeleteEmployee.razor"
                                             Emp.Notes

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n        ");
            __builder.OpenElement(76, "div");
            __builder.AddAttribute(77, "class", "col");
            __builder.AddMarkupContent(78, "\r\n            ");
            __builder.OpenElement(79, "div");
            __builder.AddMarkupContent(80, "\r\n                ");
            __builder.OpenElement(81, "input");
            __builder.AddAttribute(82, "type", "button");
            __builder.AddAttribute(83, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 57 "F:\CFP\EmployeePayroll\EmployeePayrollBlazor\Pages\DeleteEmployee.razor"
                                                DeleteCustomers

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(84, "class", "btn btn-primary");
            __builder.AddAttribute(85, "value", "YES");
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n                ");
            __builder.OpenElement(87, "input");
            __builder.AddAttribute(88, "type", "button");
            __builder.AddAttribute(89, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 58 "F:\CFP\EmployeePayroll\EmployeePayrollBlazor\Pages\DeleteEmployee.razor"
                                                Cancel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(90, "class", "btn btn-primary");
            __builder.AddAttribute(91, "value", "NO");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n\r\n            ");
            __builder.OpenComponent<MatBlazor.MatSnackbar>(94);
            __builder.AddAttribute(95, "IsOpen", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 61 "F:\CFP\EmployeePayroll\EmployeePayrollBlazor\Pages\DeleteEmployee.razor"
                                        snackBarIsOpen

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(96, "IsOpenChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => snackBarIsOpen = __value, snackBarIsOpen))));
            __builder.AddAttribute(97, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(98, "\r\n                ");
                __builder2.OpenComponent<MatBlazor.MatSnackbarContent>(99);
                __builder2.AddAttribute(100, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(101, "Deleted Successfully!");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(102, "\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(103, "\r\n\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 70 "F:\CFP\EmployeePayroll\EmployeePayrollBlazor\Pages\DeleteEmployee.razor"
       
    [Parameter]
    public string Id { get; set; }
    EmployeeModel Emp = new EmployeeModel();

    bool snackBarIsOpen = false;

    protected override async Task OnInitializedAsync()
    {
        Emp =  manager.GetEmployeeById(Convert.ToString(Id));
    }

    protected async void DeleteCustomers()
    {
        manager.DeleteEmployee(Emp.Id);

        snackBarIsOpen = true;
        this.StateHasChanged();

        await Task.Delay(2000);

        NavigationManager.NavigateTo("/show");
    }
    void Cancel()
    {
        NavigationManager.NavigateTo("/show");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IEmployeeManager manager { get; set; }
    }
}
#pragma warning restore 1591
