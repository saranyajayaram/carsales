using Microsoft.AspNetCore.Mvc;
using carsales.Models;

namespace carsales.Controllers
{
    public class CarsController : Controller
    {
        MyDbContext Context;

        public CarsController(MyDbContext context)
        {
            Context = context;
        }


        public IActionResult Index()
        {
            ViewData["CarInfo"] = "Here you can find car information";
            List<Cars> AllCars = Context.Cars.ToList();

            return View(AllCars);
        }

        public IActionResult Getcars(Cars? cars1)
        {
            /* Cars Cars = new Cars();
             Cars.Brand = "Volvo";
             Cars.Carmodel = "SUV";
             Cars.Seats = 4;
             Cars.Milage = 5345;
             Cars.Gearbox = "Automatic";
             Cars.Price = 278.34; */


            return View(cars1);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(int? id, string brand, string carmodel, int modelyear, int seats, int mileage, string gearbox, double price)
        {
            Cars cars = new Cars();
            //cars.Id = id;
            cars.Brand = brand;
            cars.Carmodel = carmodel;
            cars.Modelyear = modelyear;
            cars.Seats = seats;
            cars.Mileage = mileage;
            cars.Gearbox = gearbox;
            cars.Price = Convert.ToDouble(price);

            Context.Cars.Add(cars);
            Context.SaveChanges();
            System.Diagnostics.Debug.WriteLine("Id:" + cars.Id + "Brand:" + cars.Brand + "Carmodel:" + cars.Carmodel +
                "Modelyear" + cars.Modelyear + "Seats" + cars.Seats + "Mileage" + cars.Mileage + "Gearbox" + cars.Gearbox + "Price" + cars.Price);

            //return RedirectToAction("Getcars", cars);
            return View();
        }

        public IActionResult Edit(int? id)
        {
            Cars cars = Context.Cars.FirstOrDefault(x => x.Id == id);
            return View(cars);
        }

        [HttpPost]
        public IActionResult Edit(int? id, string brand, string carmodel, int modelyear, int seats, int mileage, string gearbox, double price)
        {
            Cars cars = Context.Cars.FirstOrDefault(x => x.Id == id);
            cars.Brand = brand;
            cars.Carmodel = carmodel;
            cars.Modelyear = modelyear;
            cars.Seats = seats;
            cars.Mileage = mileage;
            cars.Gearbox = gearbox;
            cars.Price = Convert.ToDouble(price);
            Context.SaveChanges();
            return RedirectToAction("Index");



        }

        public IActionResult Delete(int? id)
        {
            Cars cars = Context.Cars.FirstOrDefault(x => x.Id == id);
            return View(cars);
        }

        [HttpPost]
        public IActionResult DeleteYes(int? id)
        {
            Cars cars = Context.Cars.FirstOrDefault(x => x.Id == id);
            Context.Remove(cars);
            Context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
