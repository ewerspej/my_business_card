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
}