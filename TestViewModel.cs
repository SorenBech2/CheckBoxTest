using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace SfRadioButton_test
{
    public partial class TestViewModel : ObservableObject, INotifyPropertyChanged
    {
        [ObservableProperty] public TestDataModel selectedEntity = new();
        [ObservableProperty] public ObservableCollection<TestDataModel>? entityList;

        public TestViewModel()
        {
            EntityList = new ObservableCollection<TestDataModel>();
            EntityList.Add(new TestDataModel() { Id = 1, IsActive = false, Name = "1st entity"} );
            EntityList.Add(new TestDataModel() { Id = 2, IsActive = false, Name = "2nd entity" });
            EntityList.Add(new TestDataModel() { Id = 3, IsActive = true, Name = "3rd entity" });
        }

        [RelayCommand]
        public void ChangeActive()
        {
            EntityList[0].IsActive = true;
            EntityList[2].IsActive = false;

            EntityList[0].Name = "Another name";
            OnPropertyChanged(nameof(EntityList));
        }

        [RelayCommand]
        public void ChangeActiveAgain()
        {
            EntityList[0].IsActive = false;
            EntityList[2].IsActive = true;
            EntityList[0].Name = "Old name name";
            OnPropertyChanged(nameof(EntityList));
            
        }
    }
}
