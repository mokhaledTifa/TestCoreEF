using TestCoreEF.Models;

namespace TestCoreEF.Repos.CarRepos
{
    public interface ICarRepo
    {
        public void createCar(CarDB car);
    }
}
