namespace U2Actividad1.Models.ViewModels
{
    public class EspecieViewModel
    {      
        public string Especie { get; set; } = null!;
        public string Habitad { get; set; } = null!;
        public int? Tamaño { get; set; }
        public double? Peso { get; set; }
        public string Obeservaciones { get; set; } = null!;
        public int id { get; set; }
        public string ClaseAnimal { get; set; } = null!;
       
    }
}
