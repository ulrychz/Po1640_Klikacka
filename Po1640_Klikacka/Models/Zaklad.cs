namespace Po1640_Klikacka.Models
{
    public class Zaklad
    {
        public Zaklad() 
        {
            NaplnNahodnePole(radku: 10, sloupcu: 12, cisloOd: 0, cisloDo: 1);
        }
        public Bunka[,] Matice { get; set; }
        public byte ZvolenaBarva { get; set; } = 2;
        private Random rnd = new Random();
        private void NaplnNahodnePole(int radku, int sloupcu, byte cisloOd, byte cisloDo)
        {
            Matice = new Bunka[radku, sloupcu];
            for (int i = 0; i < radku; i++)
            {
                for (int j = 0; j < sloupcu; j++)
                {
                    Matice[i, j] = new Bunka(i, j, (byte)rnd.Next(cisloOd, cisloDo + 1));
                }
            }
        }

        public void OnCellClick(Models.Bunka bunka)
        {
            if (bunka.Hodnota == 0 && !(bunka.IndexBarvy == ZvolenaBarva))
            {
                bunka.IndexBarvy = ZvolenaBarva;
            }
            else
            {
                bunka.IndexBarvy = 0;
            }
        }
    }
}
