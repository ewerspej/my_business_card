namespace MyBusinessCard.QR;

public partial class QrCodePage
{
    public QrCodePage(QrCodeViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }

    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }
}