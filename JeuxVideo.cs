
public class JeuxVideo
{
    const string NOM_APP = "JEUXPRO";
    const string DEVELOPPEUR = "SOH ACHILLE";
    const string VERSION = "_01";
    /* */

    protected string _titre;
    protected string _genre;
    protected int _anneDeSortie;
    protected string _categoryJeux;

    public string TITRE {
       get => _titre;
       set => _titre = value;
    } 

     
    public JeuxVideo(string titre, string genre, int anneSortie, string category)
    {
        _titre = titre;
        _genre = genre;
        _anneDeSortie = anneSortie;
        _categoryJeux = category;
        
    }


    


    // AfficherDetails
    public  virtual void AfficherDetails()
    {

        Console.WriteLine("");
        // Result comes here
        Console.WriteLine("TITRE" + _titre);
        Console.WriteLine("ANNEE" + _anneDeSortie);
        Console.WriteLine("GENRE" + _genre);
        Console.WriteLine("CATEGORIE" + _categoryJeux);
        Console.WriteLine("");


    }
    // Manuel utilisateur (USER MANUAL)
    public static void ManuelUtilisateurs()
    {
        Console.WriteLine(" ");
        Console.WriteLine($"Bienvenue dans {NOM_APP}".ToUpper());
        Console.WriteLine(" ");
        Console.WriteLine("1. AJOUTER JEUX VIDEO :");
        Console.WriteLine("2. SUPPRIMER JEUX VIDEO :");
        Console.WriteLine("3. MODIFIER JEUX VIDEO :");
        Console.WriteLine("4. AFFICHER LA LISTES DES JEUX VIDEO : ");
        Console.WriteLine("5. QUITTER : ");
        Console.WriteLine("");
        Console.WriteLine("Entrer votre choix ici :".ToUpper());

    }
}