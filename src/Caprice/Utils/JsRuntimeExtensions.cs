using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace Caprice.Utils
{
    public static class JsRuntimeExtensions
    {
        public static async Task<bool> CheckPassword(this IJSRuntime runtime)
        {
            var password = await runtime.InvokeAsync<string>("prompt", "暗号:");

            if (password != "Caprice.2020")
            {
                await runtime.InvokeVoidAsync("alert", "路过...");

                return false;
            }

            return true;
        }
    }
}
