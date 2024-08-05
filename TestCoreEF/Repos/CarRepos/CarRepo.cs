using TestCoreEF.Models;

namespace TestCoreEF.Repos.CarRepos
{
    public class CarRepo : ICarRepo
    {
        public static List<CarDB> Cars = new List<CarDB> {
            new CarDB { Id = 1,Name="mrc"},
            new CarDB{ Id = 2,Name="Nec"},
            new CarDB{ Id = 3,Name="Ford"}
        };
        public void createCar(CarDB car)
        {
            Cars.Add(car);
        }
    }
}
