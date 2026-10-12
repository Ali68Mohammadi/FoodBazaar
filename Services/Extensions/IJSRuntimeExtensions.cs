using Microsoft.JSInterop;
 
namespace FoodBazaar.Services.Extensions
{
    public static class IJSRuntimeExtensions
    {
        public static async Task ToasterSuccess(this IJSRuntime js, string message)
        {
            await js.InvokeVoidAsync("showToaster", "success", message);
        }

        public static async Task ToasterError(this IJSRuntime js, string message)
        {
            await js.InvokeVoidAsync("showToaster", "error", message);
        }

        public static async Task ToasterWarning(this IJSRuntime js, string message)
        {
            await js.InvokeVoidAsync("showToaster", "warning", message);
        }

        public static async Task ToasterInfo(this IJSRuntime js, string message)
        {
            await js.InvokeVoidAsync("showToaster", "info", message);
        }
    }
}
