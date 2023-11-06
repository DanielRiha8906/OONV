namespace Builder
{
    class Director
    {
        public IBuilder Builder {get; set;}
        public Director(IBuilder builder)
        {
            if(builder == null)
            {
                throw new System.ArgumentNullException();
            }
            this.Builder = builder;
        }
        public void Change_Builder(IBuilder builder )
        {
            this.Builder = builder;
        }
        public void Create_basic_base()
        {   
            Builder.Build_GoldMine();
        }
        public void Create_medium_base()
        {
            Builder.Build_GoldMine();
            Builder.Build_Well();
        }
        public void Create_epic_base()
        {
            Builder.Build_GoldMine();
            Builder.Build_Well();
            Builder.Build_kasarny();
        }
    }   
}