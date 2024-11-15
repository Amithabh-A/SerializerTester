namespace ConsoleApp1
{

    public class Blah
    {
        public Blah()
        {
        }
    }

    class Program
    {
        /// <summary> Serializes an object to its string representation.
        /// </summary>
        /// <typeparam name="T">The type of the object to serialize.</typeparam>
        /// <param name="obj">The object to serialize.</param>
        /// <returns>A string representation of the serialized object.</returns>
        public static string SerializeObject<T>(T obj)
        {
            try
            {
                ISerializer serializer = new Serializer();
                return serializer.Serialize(obj);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return "";
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(SerializeObject(""));
            if (SerializeObject("") == null)
            {
                Console.WriteLine("Fail");
            }
            Blah obj = new Blah();
            if (SerializeObject(obj) == null)
            {
                Console.WriteLine("Fail");
            }
        }
    }
}
