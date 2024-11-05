using _10_GarbageCollectorExample;

internal class Program
{
    private static void Main(string[] args)
    {
        using Class1 class3 = new Class1();
        Console.WriteLine($"Obj generation : {GC.GetGeneration(class3)}");

        using Class1 class4 = new Class1();
        Console.WriteLine($"Obj Total Memory : {GC.GetTotalMemory(false)}");
        GC.Collect();
        Console.WriteLine($"Obj Total Memory : {GC.GetTotalMemory(false)}");

    }
}

namespace _10_GarbageCollectorExample
{
    public class Class1 : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Dispose!");
        }
    }
    public class Class2
    {
        public void Elias ()
        {
            using (Class1 class1 = new Class1())
            {

            }

            using Class1 class2 = new Class1();
        }
    }
}