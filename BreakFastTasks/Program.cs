using CoreCollectionsAsync;
namespace BreakFastTasks

{
    internal class Program
    {

        public static void Message(object? sender, EventArgs e)
        {
            ElectricCar c = sender as ElectricCar;
            Console.WriteLine("Car Engine Stopped");

        }
        static async Task Main(string[] args)
        {
            //  SimpleBreakfast.MakeBreakfastDemo_1();
            // TaskedBreakFast.MakeBreakfastDemo_4().Wait();
            Task[] tasks = new Task[5];
            ElectricCar[] eCars = new ElectricCar[tasks.Length];
            for (int i = 0; i < tasks.Length; i++)
            {
                eCars[i] = new ElectricCar();
                tasks[i] = eCars[i].StartEngineAsync();
            }
            await Task.WhenAll(tasks);
            Console.WriteLine("All cars finished");
        }
    }
}