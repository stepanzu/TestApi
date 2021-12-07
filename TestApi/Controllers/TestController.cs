using Microsoft.AspNetCore.Mvc;
using System.Net;
using TestApi.Models;
using TestApi.Repositories;

namespace TestApi.Controllers
{
    public class TestController : ControllerBase
    {
        [HttpGet]
        public Perro Get()
        {
            Perro perr = new Perro();
            perr.Id = 1;
            perr.Name = "Bichu";
            perr.Patas = 3;

            Animal perro = new Perro();
            Animal gato = new Perro();

            List<Animal> animals = new List<Animal>();
            animals.Add(perro);
            animals.Add(gato);


            foreach (Animal animal in animals) 
            {
                if (animal.GetType() == typeof(Perro)) 
                {
                    Console.WriteLine(((Perro)animal).Patas);
                }

            }



            return new Perro();

        }


    }
}
