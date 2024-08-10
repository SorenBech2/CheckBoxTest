namespace SfRadioButton_test;

public partial class TestPage : ContentPage
{
	TestViewModel viewModel = new();
	public TestPage()
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}