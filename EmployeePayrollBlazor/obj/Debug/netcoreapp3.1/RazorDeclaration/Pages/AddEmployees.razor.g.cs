// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#line 2 "F:\CFP\EmployeePayroll\EmployeePayrollBlazor\Pages\AddEmployees.razor"
using EmployeePayrollModelLayer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\CFP\EmployeePayroll\EmployeePayrollBlazor\Pages\AddEmployees.razor"
using EmployeePayrollManagerLayer.Interface;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/add")]
    public partial class AddEmployees : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 135 "F:\CFP\EmployeePayroll\EmployeePayrollBlazor\Pages\AddEmployees.razor"
       
    EmployeeModel employeeModel = new EmployeeModel();
    bool snackBarIsOpen = false;
    protected async void AddEmployee()
    {
        manager.AddEmployee(employeeModel);
        snackBarIsOpen = true;
        this.StateHasChanged();

        await Task.Delay(5000);
        navigate.NavigateTo("/show");

    }

    public void Redirect()
    {

        navigate.NavigateTo("/show");

    }

    protected void AddImage(string image)
    {
        employeeModel.Profile = image;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigate { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IEmployeeManager manager { get; set; }
    }
}
#pragma warning restore 1591
