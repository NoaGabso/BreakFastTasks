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
        static void Main(string[] args)
        {
            //  SimpleBreakfast.MakeBreakfastDemo_1();
         // TaskedBreakFast.MakeBreakfastDemo_4().Wait();
            ElectricCar car=new ElectricCar();
            car.CarShutDown += Message;
            car.StartEngine();
            
           
          
        }
        public static async Task MakeTasks()
        {
            Task[] t1= new Task[10];
            ElectricCar[] c1= new ElectricCar[10];
            for(int i=0;i<c1.Length;i++)
            {
                c1[i]= new ElectricCar();
                t1[i] = c1[i].StartEngineAsync();
            }
            await Task.WhenAll(t1);
        }
    }
}