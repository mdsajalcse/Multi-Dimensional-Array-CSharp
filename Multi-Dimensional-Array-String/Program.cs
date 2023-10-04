//Multi-Dimensional Array String

Console.WriteLine("Multi-Dimensional Array String::");
Console.WriteLine("...................................\n");



string[,,] books = new string[3, 3, 3]
{
    {
        { "phy","Chem","math"},{ "phy","Chem","math"},{ "phy","Chem","math"}
    },
    {
        { "Bio","Gol","math"},{ "ICT","History","Geo"},{ "phy","Chem","math"}
    }, 
    {
        { "Acc","Eco","math"},{ "phy","Chem","math"},{ "phy","Botany","math"}
    }
};

//Accesing the element of array
Console.WriteLine("First Row Of Array::");
Console.WriteLine("....................\n");

Console.WriteLine(books[0, 0, 0] + " " + books[0, 0, 1] + " " + books[0, 0, 2]);
Console.WriteLine(books[0, 1, 0] + " " + books[0, 1, 1] + " " + books[0, 1, 2]);
Console.WriteLine(books[0, 2, 0] + " " + books[0, 2, 1] + " " + books[0, 2, 2]);
Console.WriteLine("....................\n");
Console.WriteLine("Second Row Of Array::");
Console.WriteLine("....................\n");

Console.WriteLine(books[1, 0, 0] + " " + books[1, 0, 1] + " " + books[1, 0, 2]);
Console.WriteLine(books[1, 1, 0] + " " + books[1, 1, 1] + " " + books[1, 1, 2]);
Console.WriteLine(books[1, 2, 0] + " " + books[1, 2, 1] + " " + books[1, 2, 2]);
Console.WriteLine("....................\n");
Console.WriteLine("Third Row Of Array::");
Console.WriteLine("....................\n");

Console.WriteLine(books[2, 0, 0] + " " + books[2, 0, 1] + " " + books[2, 0, 2]);
Console.WriteLine(books[2, 1, 0] + " " + books[2, 1, 1] + " " + books[2, 1, 2]);
Console.WriteLine(books[2, 2, 0] + " " + books[2, 2, 1] + " " + books[2, 2, 2]);