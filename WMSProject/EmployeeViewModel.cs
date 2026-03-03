namespace WMSProject
{
    public class EmployeeViewModel
    {
        /// <summary>
        /// Éves fizetés kiszámítása
        /// </summary>

        public int HetiFutarFizetes { get; } = 15000;

        public int Osztondij { get; } = 42000;

        public int EvesFizetes => ((HetiFutarFizetes * 4) + Osztondij) * 12;

    }
}
