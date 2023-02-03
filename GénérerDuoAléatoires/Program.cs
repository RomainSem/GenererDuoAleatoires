List<string> students = new List<string>() { "Romain", "Solène", "Raph", "Laeticia", "Claire", "Vincent", "Willy", "Arnaud", "Corentin", "Charlie", "Sammy", "Yannick" };
List<List<string>> lists = new List<List<string>>();
const int listNb = 6;

Random random = new Random();
int index; // Nombre aléatoire entre 0 et students.Count

CreateListsInlists(); // Créer les listes dans la liste lists
FillListsWithTwoRandomElements(); // Remplir les listes avec 2 éléments aléatoires
DisplayListsContents(); // Affiche le contenu de chaque liste

void CreateListsInlists()
{
    {
        for (int i = 0; i < listNb; i++)
        {
            lists.Add(new List<string>());
        }
    }
}

void FillListsWithTwoRandomElements()
{
    for (int i = 0; i < lists.Count; i++)
    {
        while (lists[i].Count < 2)
        {
            index = random.Next(0, students.Count);

            if (!lists[i].Contains(students[index]))
            {
                lists[i].Add(students[index]);
                students.Remove(students[index]);
            }
        }
    }
}

void DisplayListsContents()
{
    for (int i = 0; i < listNb; i++)
    {
        Console.WriteLine("List {0}: {1}", i + 1, string.Join(", ", lists[i]));
    }
}

