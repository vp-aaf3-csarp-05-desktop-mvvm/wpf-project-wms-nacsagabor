namespace WMSProject
{
    public class EmployeeViewModel
    {
        public string Name { get; } = "Nagy Anna";

        public string AdoSzam { get; } = "12345678-1-13";

        public string KiNemAdottSzabadsag { get; } = "10";

        /// <summary>
        /// Éves fizetés kiszámítása
        /// </summary>

        public int HetiFutarFizetes { get; } = 15000;

        public int Osztondij { get; } = 42000;

        public int EvesFizetes => ((HetiFutarFizetes * 4) + Osztondij) * 12 ;

    }
}
