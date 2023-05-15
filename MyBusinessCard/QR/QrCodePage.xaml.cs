namespace MyBusinessCard.QR;

public partial class QrCodePage
{
    private readonly QrCodeViewModel _viewModel;

    public QrCodePage(QrCodeViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = _viewModel = viewModel;
    }

    private async void OnBackButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("..");
    }

    private async void OnShareButtonClicked(object sender, EventArgs e)
    {
        await Share.Default.RequestAsync(new ShareTextRequest
        {
            Title = _viewModel.Title,
            Text = _viewModel.Link
        });
    }
}