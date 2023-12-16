using PruebaPLSQL.Data;

namespace PuebaPLSQL
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var data = new UserData();
            var result = UserData.GetAllUsers();

            foreach (var user in result)
            {
                Console.WriteLine(user.Id);
            }            
        }
    }
}
