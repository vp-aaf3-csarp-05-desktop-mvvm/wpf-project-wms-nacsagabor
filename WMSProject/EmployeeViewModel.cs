using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace WMSProject
{
    public partial class EmployeeViewModel : ObservableObject
    {
        // INPUTOK
        [ObservableProperty]
        private int hetiFutarFizetesInput;

        [ObservableProperty]
        private int osztondijInput;

        // EREDMÉNY
        private int evesFizetes;
        public int EvesFizetes
        {
            get => evesFizetes;
            set => SetProperty(ref evesFizetes, value);
        }

        // GOMB PARANCS
        [RelayCommand]
        private void Calculate()
        {
            EvesFizetes = ((HetiFutarFizetesInput * 4) + OsztondijInput) * 12;
        }
    }
}