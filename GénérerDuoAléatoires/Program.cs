List<string> students = new List<string>() { "Romain", "Solène", "Raph", "Laeticia", "Claire", "Vincent", "Willy", "Arnaud", "Corentin", "Charlie", "Sammy", "Yannick" };
const int listNb = 6;
List<string> Salle1 = new List<string>();
List<string> Salle2 = new List<string>();
List<string> Salle3 = new List<string>();
List<string> Salle4 = new List<string>();
List<string> Salle5 = new List<string>();
List<string> Salle6 = new List<string>();
Random random = new Random();
int index;

while (students.Count > 0)
{
    index = random.Next(students.Count);
    Salle1.Add(students[index]);
    students.RemoveAt(index);
    
    index = random.Next(students.Count);
    Salle2.Add(students[index]);
    students.RemoveAt(index);
    
    index = random.Next(students.Count);
    Salle3.Add(students[index]);
    students.RemoveAt(index);
    
    index = random.Next(students.Count);
    Salle4.Add(students[index]);
    students.RemoveAt(index);
    
    index = random.Next(students.Count);
    Salle5.Add(students[index]);
    students.RemoveAt(index);
    
    index = random.Next(students.Count);
    Salle6.Add(students[index]);
    students.RemoveAt(index);
}
foreach (var student in Salle1)
{

    Console.WriteLine("Salle 1 :" + student);
}
foreach (var student in Salle2)
{

    Console.WriteLine("Salle 2 :" + student);
}
foreach (var student in Salle3)
{

    Console.WriteLine("Salle 3 :" + student);
}
foreach (var student in Salle4)
{

    Console.WriteLine("Salle 4 :" + student);
}
foreach (var student in Salle5)
{

    Console.WriteLine("Salle 5 :" + student);
}
foreach (var student in Salle6)
{

    Console.WriteLine("Salle 6 :" + student);
}

List<string>


