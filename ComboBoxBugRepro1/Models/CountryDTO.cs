using CommunityToolkit.Mvvm.ComponentModel;

namespace ComboBoxBugRepro1.Models
{
    internal sealed partial class CountryDTO : ObservableObject
    {
        [ObservableProperty]
        private int _id;
        [ObservableProperty]
        private int _regionId;
        [ObservableProperty]
        private string _name = null!;
    }
}
