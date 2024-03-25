namespace Po1640_Klikacka.Models
{
    public class Bunka
    {
        public Bunka(int radka, int sloupec, byte hodnota)
        { 
            Radka = radka;
            Sloupec = sloupec;
            Hodnota = hodnota;
        }
        public int Radka { get; private set; }
        public int Sloupec { get; private set; }
        public byte Hodnota { get; private set; }
        public byte IndexBarvy { get; set; }
        public string StylBarvy => $"barva-{IndexBarvy}";
    }
}
