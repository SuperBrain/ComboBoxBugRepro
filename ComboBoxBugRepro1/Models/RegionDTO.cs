using CommunityToolkit.Mvvm.ComponentModel;

namespace ComboBoxBugRepro1.Models
{
    internal sealed partial class RegionDTO : ObservableObject
    {
        [ObservableProperty]
        private int _id;
        [ObservableProperty]
        private string _name = null!;
    }
}
