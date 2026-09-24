namespace HelloApp;

partial class Program
{
    static void Collections()
    {
        HashSet<string> users = ["Luis", "Pedro", "Pablo"];
        users.Add("Melissa");
        users.Add("Maria");
        users.Add("Luis");

        foreach (var user in users)
        {
            Console.WriteLine(user);
        }
    }
} 