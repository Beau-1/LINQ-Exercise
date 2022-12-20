

List<string> names = new List<string>()
{
    "Super Mario Bros.", "Batman", "Comand and Conqure", "Street Fighter", "Hunt:Showdown"
};

IEnumerable<string> sortedList = names.OrderBy(x => x.Length);


foreach (var item in sortedList)
{
    Console.WriteLine(item);
}