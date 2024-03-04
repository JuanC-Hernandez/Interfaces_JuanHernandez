namespace Interfaces_JuanHernandez
{
    internal class Program
    {
        // Juan Hernandez
        // Interace
        // 02/23/24
        static void Main(string[] args)
        {
            List<IOpen> opens = new List<IOpen>();

            opens.Add(new Bottle());
            opens.Add(new Chest());
            opens.Add(new Door());

            foreach (IOpen item in opens)
            {
                item.Open();
            }
            
            Console.ReadKey();
        }
    }
}
