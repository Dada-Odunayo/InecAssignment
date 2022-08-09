namespace InecAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FindDuplicate();
            NoDuplicateEntry();
        }

        //method to prevent duplicate entry
        public static void NoDuplicateEntry()
        {
            Console.WriteLine("\nWelcome to INEC registration\n");
            Console.WriteLine("Please enter your name to get registered");

            string name = Console.ReadLine().ToLower();


            var hs = new HashSet<string>() { "tayo","bisola","victory","temi","tope"};
            
                if (hs.Contains(name))
                {
                    Console.WriteLine($"{name} already exists in the database");
                }
                else
                {
                    hs.Append(name);
                    Console.WriteLine($"{name} has been successfully added to the database");
                }
               
            

            
        }

        //method to find duplicate names in array
        public static void FindDuplicate()
        {
            string[] names = { "Nas","Nas","Bola","Ogo","Ogo","Nas","Ama","John",
                "Peculiar","Ama","Vincent" };
            
            var dictNames = new Dictionary<string, int>();

            //loops through the array of names
            
            foreach(var name in names)
            {
                //checks if name is repeated and counts the
                //amount of time it was repeated
                if (dictNames.ContainsKey(name))
                {
                    dictNames[name]++;
                }
                else
                {
                    dictNames[name] = 1;
                }
            }
            //prints the name and number of times its repeated
            foreach(var pair in dictNames)
            {
                Console.WriteLine($"The name {pair.Key} appeared {pair.Value} times");
            }

            
            
        }
    }
}