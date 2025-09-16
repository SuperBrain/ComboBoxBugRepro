using ComboBoxBugRepro1.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace ComboBoxBugRepro1.ViewModels
{
    internal sealed partial class MainWindowViewModel : ObservableObject
    {
        private List<RegionDTO> AllRegions = [
            new() { Id = 1, Name = "North America" },
            new() { Id = 2, Name = "Central and Latin America" },
            new() { Id = 3, Name = "Europe" },
            new() { Id = 4, Name = "Middle East and Africa" },
            new() { Id = 5, Name = "Asia and Pacific" }];
        private List<CountryDTO> AllCountries = [
            new() { Id = 1, RegionId = 1, Name = "United States" },
            new () { Id = 2, RegionId = 1, Name = "Canada" },
            new () { Id = 3, RegionId = 1, Name = "Puerto Rico" },
            new() { Id = 4, RegionId = 2, Name = "Mexico" },
            new() { Id = 5, RegionId = 2, Name = "Argentina" },
            new() { Id = 6, RegionId = 2, Name = "Colombia" },
            new() { Id = 7, RegionId = 2, Name = "Chile" },
            new() { Id = 8, RegionId = 2, Name = "Peru" },
            new() { Id = 9, RegionId = 3, Name = "Austria" },
            new() { Id = 10, RegionId = 3, Name = "Belgium" },
            new() { Id = 11, RegionId = 3, Name = "Switzerland" },
            new() { Id = 12, RegionId = 3, Name = "Germany" },
            new() { Id = 13, RegionId = 3, Name = "Denmark" },
            new() { Id = 14, RegionId = 3, Name = "Spain" },
            new() { Id = 15, RegionId = 3, Name = "Finland" },
            new() { Id = 16, RegionId = 3, Name = "France" },
            new() { Id = 17, RegionId = 3, Name = "United Kingdom" },
            new() { Id = 18, RegionId = 3, Name = "Greece" },
            new() { Id = 19, RegionId = 3, Name = "Hungary" },
            new() { Id = 20, RegionId = 3, Name = "Italy" },
            new() { Id = 21, RegionId = 3, Name = "Netherlands" },
            new() { Id = 22, RegionId = 3, Name = "Poland" },
            new() { Id = 23, RegionId = 3, Name = "Portugal" },
            new() { Id = 24, RegionId = 4, Name = "United Arab Emirates" },
            new() { Id = 25, RegionId = 4, Name = "Bahrain" },
            new() { Id = 26, RegionId = 4, Name = "Egypt" },
            new() { Id = 27, RegionId = 4, Name = "Ghana" },
            new() { Id = 28, RegionId = 4, Name = "Israel" },
            new() { Id = 29, RegionId = 4, Name = "Kenya" },
            new() { Id = 30, RegionId = 4, Name = "Kuwait" },
            new() { Id = 31, RegionId = 4, Name = "Nigeria" },
            new() { Id = 32, RegionId = 4, Name = "Oman" },
            new() { Id = 33, RegionId = 4, Name = "Qatar" },
            new() { Id = 34, RegionId = 4, Name = "Saudi Arabia" },
            new() { Id = 35, RegionId = 5, Name = "Australia" },
            new() { Id = 36, RegionId = 5, Name = "Brunei" },
            new() { Id = 37, RegionId = 5, Name = "China" },
            new() { Id = 38, RegionId = 5, Name = "Indonesia" },
            new() { Id = 39, RegionId = 5, Name = "India" },
            new() { Id = 40, RegionId = 5, Name = "Japan" },
            new() { Id = 41, RegionId = 5, Name = "South Korea" },
            new() { Id = 42, RegionId = 5, Name = "Malaysia" },
            new() { Id = 43, RegionId = 5, Name = "New Zealand" },
            new() { Id = 44, RegionId = 5, Name = "Philippines" },
            new() { Id = 45, RegionId = 5, Name = "Singapore" },
            new() { Id = 46, RegionId = 5, Name = "Thailand" },
            new() { Id = 47, RegionId = 5, Name = "Taiwan" }];

        [ObservableProperty]
        private ObservableCollection<RegionDTO> _regions = [];
        [ObservableProperty]
        private RegionDTO? _selectedRegion;
        partial void OnSelectedRegionChanged(RegionDTO? value)
        {
            if (value is not null)
            {
                Countries = [.. AllCountries.Where(c => c.RegionId == value.Id) ];
            }
            else
            {
                Countries = [];
                SelectedCountry = null;
            }
        }
        [ObservableProperty]
        private ObservableCollection<CountryDTO> _countries = [];
        [ObservableProperty]
        private CountryDTO? _selectedCountry;

        public MainWindowViewModel()
        {
            Regions = [.. AllRegions];
        }
    }
}
