using System.Web;
using MyBusinessCard.QR;

namespace MyBusinessCard;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnLinkedInButtonClicked(object sender, EventArgs e)
    {
        var link = HttpUtility.UrlEncode("http://linkedin.com/in/jewerspeters");
        await Shell.Current.GoToAsync(nameof(QrCodePage) + $"?Link={link}&Title=LinkedIn");
    }

    private async void OnBlogClicked(object sender, EventArgs e)
    {
        var link = HttpUtility.UrlEncode("http://ewerspej.hashnode.dev");
        await Shell.Current.GoToAsync(nameof(QrCodePage) + $"?Link={link}&Title=Blog");
    }

    private async void OnWebButtonClicked(object sender, EventArgs e)
    {
        var link = HttpUtility.UrlEncode("http://ewerspej.gatsbyjs.io");
        await Shell.Current.GoToAsync(nameof(QrCodePage) + $"?Link={link}&Title=Website");
    }
}