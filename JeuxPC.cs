public class JeuxPC: JeuxVideo
{
    private string _configuration;
    public JeuxPC(string titre, string genre, int anneDate, string categoryJeux, string configuration) : base(titre,genre,anneDate, categoryJeux)
    {
        _configuration = configuration;
    }

    public override void AfficherDetails()
    {
        //base.AfficherDetails();
    }

}