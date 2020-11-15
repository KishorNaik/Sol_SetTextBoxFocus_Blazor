using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Demo.Extensions
{
    public static class SetFocusExtension
    {
        public static async Task SetFocusAsync(this ElementReference elementReference, IJSRuntime jsRuntime)
        {
            await jsRuntime.InvokeVoidAsync(
                    "setFocusJs", elementReference);
        }
    }
}
