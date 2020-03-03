using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace Caprice.Utils
{
    public static class JsRuntimeExtensions
    {
        public static async Task<bool> CheckPassword(this IJSRuntime runtime)
        {
            string password = await runtime.InvokeAsync<string>("prompt", "暗号:");

            if (password == null)
            {
                return false;
            }

            if (password != "Caprice.2020")
            {
                await runtime.AlertAsync("路过...");

                return false;
            }

            return true;
        }

        public static async Task AlertAsync(this IJSRuntime runtime, string message)
        {
            await runtime.InvokeVoidAsync("alert", message);
        }
    }
}
