public class Program
{
    public static void Main()
    {
        /*@ Variable global ici */
        List<JeuxVideo> JeuxVideosList = new List<JeuxVideo>();
        bool CestUnJeux = true;

    do
    {
        /*@ User manuel START utilisateurs ici */
        JeuxVideo.ManuelUtilisateurs();
        string? ChoixUtilisateur = Console.ReadLine();
        /* User manuel END utilisateurs ici */
        switch (ChoixUtilisateur)
        {
            case "1":
            /*ICI J'appelle juste la classe static qui contines le monteur principal du projet */
            Controller.AjouterJeux(JeuxVideosList);
            break;
            case "2":
            Controller.SupprimerJeux(JeuxVideosList);
            break;
            case "3":
            Controller.ModifierJeux(JeuxVideosList);
            break;
            case "4":
            Controller.GetAllJeuxVideo(JeuxVideosList);

            break;
            case "5":
            Console.WriteLine("");
            Console.WriteLine("Bonne journee a vous a la procahine");
            CestUnJeux = false;
            break;

            
            default:
            Console.WriteLine($"*{ChoixUtilisateur}*  {STATUS.NOTFOUND} n'xiste pas desole");
            break;
        }

    }while(CestUnJeux != false);

    }
}

/* Merci a (**DIEU SEUL EST GRAND**) */
/* Etudiant (SOH TAGNE ACHILLE IVES) */






