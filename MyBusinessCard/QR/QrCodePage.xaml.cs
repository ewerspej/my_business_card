namespace MyBusinessCard.QR;

public partial class QrCodePage
{
	public QrCodePage(QrCodeViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
}