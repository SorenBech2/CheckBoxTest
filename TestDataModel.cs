using CommunityToolkit.Mvvm.ComponentModel;

namespace SfRadioButton_test
{
    public partial class TestDataModel : ObservableObject
    {
        public int Id { get; set; }

        [ObservableProperty]
        public string? name;

        [ObservableProperty]
        public bool isActive = false;
    }
}
