

public static class DemarageStatic
{

    /* Ajouter un nouveau jeux video */
    public static List<JeuxVideo> AjouterJeux(List<JeuxVideo> ListJeux)
    {   string JeuxVideo;
         
        Console.WriteLine($"Entrer le titre du ${nameof(JeuxVideo)}");
        string Titre = Console.ReadLine()!;
        Console.WriteLine($"Entrer le genre du ${nameof(JeuxVideo)}");
        string Genre = Console.ReadLine()!;
        Console.WriteLine($"Entrer le L'anne du ${nameof(JeuxVideo)}");
        string AnnerDeSortie = Console.ReadLine()!;
        int.TryParse(AnnerDeSortie, out int anneDesortie);
        Console.WriteLine($"Entrer le category du ${nameof(JeuxVideo)}");
        string Category = Console.ReadLine()!;
        Console.WriteLine($"Entrer les configurations du ${nameof(JeuxVideo)}");
        string Configurations = Console.ReadLine()!;

        
        try
        {
            if(Category == "Jeux Pc".ToLower())
            {
                var JeuxPc = new JeuxPC(Titre, Genre, anneDesortie, Category, Configurations);
                ListJeux.Add(JeuxPc);
                Console.WriteLine($"{STATUS.SUCCESS} JEUX AJOUTER");
            }
            if(Category == "Jeux Console".ToLower())
            {
                var JeuxConsole = new JeuxConsole(Titre, Genre, anneDesortie, Category, Configurations);
                ListJeux.Add(JeuxConsole);
                Console.WriteLine($"{STATUS.SUCCESS} JEUX AJOUTER");
                
                
            }
        }catch(Exception e)
        {
            throw new ($"{nameof(STATUS)} {STATUS.ERROR}  {Category} n'est pas valide " + e.Message);
        }

 
        return ListJeux;
        

    }

    


}