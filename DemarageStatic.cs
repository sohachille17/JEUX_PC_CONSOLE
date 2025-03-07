

public static class DemarageStatic
{

    /* Ajouter un nouveau jeux video */
    public static List<JeuxVideo> AjouterJeux(List<JeuxVideo> ListJeux)
    {   string JeuxVideo;
        string AnnerDeSortie;
         
        Console.WriteLine($"Entrer le titre du :{nameof(JeuxVideo)}");
        string Titre = Console.ReadLine()!;
        Console.WriteLine($"Entrer le genre du :{nameof(JeuxVideo)}");
        string Genre = Console.ReadLine()!;
        Console.WriteLine($"Entrer L'anne du :{nameof(JeuxVideo)}");

        AnnerDeSortie = Console.ReadLine()!;
        bool isConvert = int.TryParse(AnnerDeSortie, out int anneDesortie);
        
        Console.WriteLine($"Entrer le category du :{nameof(JeuxVideo)}");
        string Category = Console.ReadLine()!;
        Console.WriteLine($"Entrer les configurations du :{nameof(JeuxVideo)}");
        string Configurations = Console.ReadLine()!;

        if(isConvert == false)
        {
            Console.WriteLine($"L'annee {AnnerDeSortie} n'est pas valide ");
            Console.WriteLine($"{STATUS.ERROR} Invalide {AnnerDeSortie}");
        }
        if(isConvert == true)
        {
            if(Category.ToLower() == "Jeux PC".ToLower())
            {
                var JeuxPc = new JeuxPC(Titre, Genre, anneDesortie, Category, Configurations);
                ListJeux.Add(JeuxPc);
                Console.WriteLine($"{STATUS.SUCCESS} JEUX AJOUTER");
            }else if(Category.ToLower() == "Jeux Console".ToLower())
            {
                var JeuxConsole = new JeuxConsole(Titre, Genre, anneDesortie, Category, Configurations);
                ListJeux.Add(JeuxConsole);
                Console.WriteLine($"{STATUS.SUCCESS} JEUX AJOUTER");
            }else
            {
                Console.WriteLine($"La category {Category} n'est pas valide");
            }  



        }
        

        
        return ListJeux;

    }

    public static List<JeuxVideo> ModifierJeux(List<JeuxVideo> ListJeux)
    {

        /* Show the list of available movies to the user */
        for(int i = 0; i < ListJeux.Count; i++)
        {

            Console.WriteLine( $"[{i + 1}] " + ListJeux[i].TITRE);

        }
        /* Show the list of available movies to the user */
        Console.WriteLine(" ");
        Console.WriteLine("Donner l'Index du jeux video que vous voulez modifier");
        string Index = Console.ReadLine()!;
        int.TryParse(Index, out int Indice);

        //Afficher List des donner a modifier
        ListJeux[Indice - 1].AfficherDetails();

        // Entere les valeur respectives

        string JeuxVideo;
        string AnnerDeSortie;
         
        Console.WriteLine($"Entrer le titre du :{nameof(JeuxVideo)}");
        string Titre = Console.ReadLine()!;
        Console.WriteLine($"Entrer le genre du :{nameof(JeuxVideo)}");
        string Genre = Console.ReadLine()!;
        Console.WriteLine($"Entrer L'anne du :{nameof(JeuxVideo)}");

        AnnerDeSortie = Console.ReadLine()!;
        bool isConvert = int.TryParse(AnnerDeSortie, out int anneDesortie);
        
        Console.WriteLine($"Entrer le category du :{nameof(JeuxVideo)}");
        string Category = Console.ReadLine()!;
        Console.WriteLine($"Entrer les configurations du :{nameof(JeuxVideo)}");
        string Configurations = Console.ReadLine()!;

        if(isConvert == false)
        {
            Console.WriteLine($"L'annee {AnnerDeSortie} n'est pas valide ");
            Console.WriteLine($"{STATUS.ERROR} Invalide {AnnerDeSortie}");
        }

        if(isConvert == true)
        {
                if(Category.ToLower() == "Jeux PC".ToLower())
                {
                    ListJeux[Indice - 1] = new JeuxPC(
                        Titre,
                        Genre,
                        anneDesortie,
                        Category,
                        Configurations);
                    
                    Console.WriteLine($"Le jeux {ListJeux[Indice - 1].TITRE} a ete mise ajours");
                } 
                if(Category.ToLower() == "Jeux Console".ToLower())
                {
                    ListJeux[Indice - 1] = new JeuxConsole(
                        Titre,
                        Genre,
                        anneDesortie,
                        Category,
                        Configurations
                    );

                    Console.WriteLine($"Le jeux {ListJeux[Indice - 1].TITRE} a ete mise ajours");
                } 
        }


            

        return ListJeux;
    }

    public static void SupprimerJeux(List<JeuxVideo> ListJeux)
    {
                /* Show the list of available movies to the user */
        for(int i = 0; i < ListJeux.Count; i++)
        {

            Console.WriteLine( $"[{i + 1}] " + ListJeux[i].TITRE);

        }
        Console.WriteLine("");
          Console.WriteLine("Donner l'Index du jeux video que vous voulez supprimer");
        string Index = Console.ReadLine()!;
        bool ConVertIndex = int.TryParse(Index, out int Indice);
        if(ConVertIndex == true)
        {
            if(Indice > ListJeux.Count)
            {
                Console.WriteLine("L'indice n'existe pas");
            }else{
                ListJeux.RemoveAt(Indice - 1);
            }
            
        }
        


    }

    public static void GetAllJeuxVideo(List<JeuxVideo> JeuxVideosList)
    {
        for(int i = 0; i < JeuxVideosList.Count; i++)
        {
            Console.WriteLine($"======== {i + 1} =======");
            JeuxVideosList[i].AfficherDetails();
            Console.WriteLine($"======== END =======");
        }
    }

    


}