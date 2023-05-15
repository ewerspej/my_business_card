using CommunityToolkit.Mvvm.ComponentModel;

namespace MyBusinessCard.QR;

[QueryProperty(nameof(Link), nameof(Link))]
[QueryProperty(nameof(Title), nameof(Title))]
public partial class QrCodeViewModel : ObservableObject
{
    [ObservableProperty]
    private string _title;

    [ObservableProperty]
    private string _link;
}