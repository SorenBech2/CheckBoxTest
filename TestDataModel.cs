using CommunityToolkit.Mvvm.ComponentModel;

namespace CheckBoxTest
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
