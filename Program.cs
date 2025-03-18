// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int[] numbers = { 5, 8, 7, 3, 4 };
Console.WriteLine(numbers[3]);

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}

int[,] matrix = { { 1, 8, 7 }, { 2, 4, 6 } };
Console.WriteLine("Matrix");
Console.WriteLine(matrix[0, 1]);

int[][] jagged = new int[3][];
jagged[0] = new int[] { 1, 4, 7 };
jagged[1] = new int[] { 2, 5, 8 };
jagged[2] = new int[] { 3, 6, 9 };
Console.WriteLine("Jagged array");
Console.WriteLine(jagged[1][1]);

List<string> names = new List<string> { "Mahmut", "Mesut", "Ömer" };
names.Add("Mehmet");
names.Remove("Mesut");
names.Insert(1, "Can");

foreach (var name in names)
{
    Console.WriteLine(name);
}

Dictionary<int, string> students = new Dictionary<int, string>
{

    {100,"Mahmut"},
    {101,"Mesut"},
    {102,"Ömer"}
};

students[103] = "İbrahim";

Console.WriteLine("Dictionary");
if (students.ContainsKey(102))
{
    Console.WriteLine("102 numaralı öğrenci: " + students[102]);
}
Console.WriteLine("Students List:");
foreach (var student in students)
{

    Console.WriteLine($"No:{student.Key}, Name: {student.Value}");
}

HashSet<int> elements = new HashSet<int>
{1,4,7,2,5,8,3,6,9,2,5,8,3,6,9,1,4,7,};
elements.Add(0);
elements.Add(3);
Console.WriteLine("HashSet:");
foreach (var element in elements)
{
    Console.WriteLine(element);
}