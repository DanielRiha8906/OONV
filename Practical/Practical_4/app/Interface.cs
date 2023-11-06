namespace Builder{
interface IBuilder
{
    public string Kasarny{set;get;}
    public string Well{set;get;}
    public string GoldMine{set;get;}
    string Build_kasarny();
    string Build_Well();
    string Build_GoldMine();
}
}