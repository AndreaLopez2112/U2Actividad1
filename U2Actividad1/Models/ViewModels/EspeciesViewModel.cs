namespace U2Actividad1.Models.ViewModels
{
    public class EspeciesViewModel
    {
        public List<Animal> animales = new List<Animal>();
        public int id { get; set; }
        public string Clase { get; set; } = null!;
    } 

    public class Animal 
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
    }
   
}
