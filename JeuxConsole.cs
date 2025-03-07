public class JeuxConsole: JeuxVideo
{
    protected string _configuration;
    public JeuxConsole(string titre, string genre, int anneDate, string categoryJeux, string configuration) : base(titre,genre,anneDate, categoryJeux)
    {
        _configuration = configuration;
    }


    public override void AfficherDetails()
    {
        //base.AfficherDetails();
    }
}