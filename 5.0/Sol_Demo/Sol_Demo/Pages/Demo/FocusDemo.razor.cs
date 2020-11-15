using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace Sol_Demo.Pages.Demo
{
    public partial class FocusDemo
    {
        #region Private Property
        private ElementReference TxtInput{get;set;}
        #endregion 

        #region Ui Events
        private async Task OnFocus(){
            await TxtInput.FocusAsync();
        }
        #endregion 
    }
}
