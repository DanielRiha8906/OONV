namespace Builder
{

    class Orc_Builder : IBuilder
    {
        public string Kasarny { set; get; }
        public string Well { set; get; }
        public string GoldMine { set; get; }
        public Orc_Builder(string? kasarny, string? well, string? goldMine)
        {
            if (kasarny == null)
            {
                kasarny = "Orc kasarny";
            }
            this.Kasarny = kasarny;
            if (well == null)
            {
                well = "Orc well";
            }
            this.Well = well;
            if (goldMine == null)
            {
                goldMine = "Orc goldMine";
            }
            this.GoldMine = goldMine;
        }
        public string Build_kasarny()
        {
            return (this.Kasarny);
        }
        public string Build_Well()
        {
            return (this.Well);
        }
         public string Build_GoldMine()
        {
            return (this.GoldMine);
        }
        public static void Zakric()
        {
            Console.WriteLine("LOKTAR OGAR VÁLEČNÍCI");
        }
    }
   
}