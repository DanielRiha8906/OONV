namespace Builder
{
    class Program
    {
        public static void Main()
        {   
            Orc_Builder zump = new Orc_Builder(null, null, null);
            Director director = new Director(zump);
            director.Create_basic_base();
        }
    }
}