namespace Manager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=ATARA;Initial Catalog=ApiDB;Integrated Security=True;Encrypt=False";
            //int numRoW=DB.InsertProducts(connectionString);
            //Console.WriteLine($"rows effected {numRoW}");
            //DB.printProducts(connectionString);
            int numRoW1 = DB.InsertCategories(connectionString);
            Console.WriteLine($"rows effected {numRoW1}");
            DB.printCategories(connectionString);

        }
    }
}
