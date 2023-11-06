namespace Builder
{

    class Human_Builder : IBuilder
    {
        public string Kasarny { set; get; }
        public string Well { set; get; }
        public string GoldMine { set; get; }
        public Human_Builder(string kasarny, string well, string goldMine)
        {
            if (kasarny == null)
            {
                kasarny = "Human kasarny";
            }
            this.Kasarny = kasarny;
            if (well == null)
            {
                well = "Human well";
            }
            this.Well = well;
            if (goldMine == null)
            {
                goldMine = "Human goldMine";
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
        public static string Stezuj_si()
        {
            return ("Vy že jste král? Vás teda volit nebudu.");
        }
    }

}