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
        DemarageStatic.AjouterJeux(JeuxVideosList);
        break;
        case "2":
        DemarageStatic.SupprimerJeux(JeuxVideosList);
        break;
        case "3":
        DemarageStatic.ModifierJeux(JeuxVideosList);
        break;
        case "4":
        DemarageStatic.GetAllJeuxVideo(JeuxVideosList);

        break;
        case "5":
        CestUnJeux = false;
        break;

        
        default:
        Console.WriteLine("Default");
        break;
    }

}while(CestUnJeux != false);



