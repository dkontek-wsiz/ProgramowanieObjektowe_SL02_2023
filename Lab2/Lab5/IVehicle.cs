namespace Lab2.Lab5
{
    public interface IVehicle
    {
        int MaxSpeed { get; set; }
        
        void Start() {
            Console.WriteLine("Start");
        }

        void Stop();
    }


    public class Car : IVehicle
    {
        public int MaxSpeed { get; set; }

        public void Stop()
        {
            throw new Exception("Popsute hamulce");
        }

        public void Start()
        {
            if (MaxSpeed < 0)
                throw new NotImplementedException();
            else
                Console.WriteLine("Jaada");
        }
    }
}
