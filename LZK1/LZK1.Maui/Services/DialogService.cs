using System.Net.Mime;
using LZ1.App.Services;
using LZ1.Core;
using LZ1.Core.Services;
using Microsoft.Maui.Controls;

namespace LZ1.App.Services;

public class DialogService : IDialogService
{
    public async Task<bool> AskAsync(string message)
    {
        return !await GetMainPage().DisplayAlert("Confirm", message, "Yes", "No");
    }

    public Task Show(string message)
    {
        return GetMainPage().DisplayAlert("Message", message, "OK");
    }

    private static Page GetMainPage()
    {
        if (MediaTypeNames.Application.Current != null && MediaTypeNames.Application.Current.MainPage != null)
        {
            return MediaTypeNames.Application.Current.MainPage;
        }

        throw new InvalidOperationException("DialogService.MainPage cannot be null.");
    }
}