namespace CheckBoxTest;

public partial class TestPage : ContentPage
{
	TestViewModel viewModel = new();
	public TestPage()
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}