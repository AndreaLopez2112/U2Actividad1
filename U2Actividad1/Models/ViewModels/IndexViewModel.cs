namespace U2Actividad1.Models.ViewModels
{
    public class IndexViewModel
    {
        public List<ClaseAnimal> clasesAnimales { get; set; } = null!;
    }
    public class ClaseAnimal
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Descripcion { get; set; } = null!;
    }
}
