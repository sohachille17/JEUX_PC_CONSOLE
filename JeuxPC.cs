public class JeuxPC: JeuxVideo
{
    protected string _configuration;
    public JeuxPC(string titre, string genre, int anneDate, string categoryJeux, string configuration) : base(titre,genre,anneDate, categoryJeux)
    {
        _configuration = configuration;
    }

    public override void AfficherDetails()
    {
        //base.AfficherDetails();

        Console.WriteLine("");
        // Result comes here
        Console.WriteLine("TITRE :" + _titre);
        Console.WriteLine("ANNEE :" + _anneDeSortie);
        Console.WriteLine("GENRE :" + _genre);
        Console.WriteLine("CATEGORIE :" + _categoryJeux);
        Console.WriteLine("CONFIG :" + _configuration);
        Console.WriteLine("");

    }

}