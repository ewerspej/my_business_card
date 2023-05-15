using MyBusinessCard.QR;

namespace MyBusinessCard;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute(nameof(QrCodePage), typeof(QrCodePage));
    }
}
