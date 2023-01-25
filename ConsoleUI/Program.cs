using Business.Concrate;
using DataAccess.Concrate.InMemory;


CarManager carManager = new CarManager(new InMemoryCarDal());

foreach(var car in carManager.GetAll())
{
    Console.WriteLine(car.Description);
}