List<string> students = new List<string>() { "Romain", "Solène", "Raph", "Laeticia", "Claire", "Vincent", "Willy", "Arnaud", "Corentin", "Charlie", "Sammy", "Yannick" };
List<List<string>> groups = new List<List<string>>();
const int listNb = 6;

Random random = new Random();
int index; // Nombre aléatoire entre 0 et students.Count

CreateListsInlists(); // Créer les listes dans la liste groups
FillListsWithTwoRandomElements(); // Remplir les listes avec 2 éléments aléatoires
DisplayListsContents(); // Affiche le contenu de chaque liste

Console.ReadLine();

void CreateListsInlists()
{
    {
        for (int i = 0; i < listNb; i++)
        {
            groups.Add(new List<string>());
        }
    }
}

void FillListsWithTwoRandomElements()
{
    for (int i = 0; i < groups.Count; i++)
    {
        while (groups[i].Count < 2)
        {
            index = random.Next(0, students.Count);
            
            groups[i].Add(students[index]);
            students.Remove(students[index]);

        }
    }
}

void DisplayListsContents()
{
    for (int i = 0; i < listNb; i++)
    {
        Console.WriteLine("Group {0} : {1} ", i + 1, string.Join(", ", groups[i]));
    }
}

