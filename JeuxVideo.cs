
public class JeuxVideo
{
    const string NOM_APP = "JEUXROO";
    const string DEVELOPPEUR = "SOH ACHILLE";
    /* */

    protected string _titre;
    protected string _genre;
    protected int _anneDeSortie;
    protected string _categoryJeux;


     
    public JeuxVideo(string titre, string genre, int anneSortie, string category)
    {
        _titre = titre;
        _genre = genre;
        _anneDeSortie = anneSortie;
        _categoryJeux = category;
        
    }


    


    // AfficherDetails
    public virtual void AfficherDetails()
    {
        // Result comes here
    }
    // Manuel utilisateur (USER MANUAL)
    public static void ManuelUtilisateurs()
    {
        Console.Clear();
        Console.WriteLine($"Bienvenue dans {NOM_APP}");
        Console.WriteLine("1. AJOUTER JEUX VIDEO ");
        Console.WriteLine("2. SUPPRIMER JEUX VIDEO ");
        Console.WriteLine("3. MODIFIER JEUX VIDEO");
        Console.WriteLine("4. AFFICHER LA LISTES DES JEUX VIDEO : ");

    }
}