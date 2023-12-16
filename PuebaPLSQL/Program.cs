using PruebaPLSQL.Data;

namespace PuebaPLSQL
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var data = new UserData();
            var result = data.GetAllUsers();

            await foreach (var user in result)
            {
                Console.WriteLine(user.Username);
            }            
        }
    }
}
