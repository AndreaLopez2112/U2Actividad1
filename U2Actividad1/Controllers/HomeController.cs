using Microsoft.AspNetCore.DataProtection.KeyManagement;
using Microsoft.AspNetCore.Mvc;
using U2Actividad1.Models.Entities;
using U2Actividad1.Models.ViewModels;

namespace U2Actividad1.Controllers
{  
    public class HomeController : Controller
    {
        public IActionResult Index(IndexViewModel ViewModel)
        {
            AnimalesContext context = new AnimalesContext();
            List<ClaseAnimal> datos = context.Clase.Select(Clase => new ClaseAnimal
            {
                Id = Clase.Id,
                Nombre = Clase.Nombre,
                Descripcion = Clase.Descripcion 
                
            }).ToList();
            ViewModel.clasesAnimales = datos;
            return View(ViewModel);
        }
        public IActionResult Especies(string id)
        {
            EspeciesViewModel especiesViewModel = new EspeciesViewModel();
            AnimalesContext especiesContext = new AnimalesContext();
            List<Animal> animales = especiesContext.Especies.Where(animal => animal.IdClaseNavigation.Nombre == id)
                .Select(x => new Animal
                {
                    Nombre = x.Especie,
                    Id = x.Id
                }).ToList();
            especiesViewModel.animales = animales;
            especiesViewModel.Clase = id;
            especiesViewModel.id = especiesContext.Clase.Where(clase => clase.Nombre== id).Select(x=>x.Id).FirstOrDefault();
            return View(especiesViewModel);
        }

        public IActionResult Especie(string id)
        {
            AnimalesContext context = new AnimalesContext();
            EspecieViewModel vm = context.Especies.Where(x=>x.Especie== id).Select(x=> new EspecieViewModel 
            {
                id = x.Id,
                Especie = x.Especie,
                Habitad = x.Habitat,
                Tamaño = x.Tamaño,
                Peso = x.Peso,
                Obeservaciones = x.Observaciones,
                ClaseAnimal = x.IdClaseNavigation.Nombre,
            }).First(); 
            return View(vm);
        }
    }
}
