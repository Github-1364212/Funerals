namespace Funerals.Views;

public partial class PackagePage : ContentPage
{
    public List<Package> Packages { get; set; }

    public PackagePage()
	{
		InitializeComponent();
        LoadData();
        BindingContext = this;
    }
    private void LoadData()
    {
        Packages = new List<Package>
        {
            new Package()
            {
                Id = 1,
                Image = "package_funeral.jpg",
                Title = "PAQUETE FUNERALS",
                Description = "El mejor Funeral Digno, Integral y al precio más asequible a nivel nacional."
            },
            new Package()
            {
                Id = 2,
                Image = "cremation.jpg",
                Title = "CREMACIÓN ASISTIDA",
                Description = "Una cremación asistida/directa es aquella en la que se realiza un pequeño servicio de aproximadamente 15 ..."
            },
            new Package()
            {
                Id = 3,
                Image = "gold_tree.jpg",
                Title = "PAQUETE FUNERARIO DE BRONCE",
                Description = "El paquete funerario Bronce para su ser querido."
            },
            new Package()
            {
                Id = 4,
                Image = "full_cremation.jpg",
                Title = "PAQUETE DE CREMACIÓN DE SERVICIO COMPLETO",
                Description = "Una cremación de servicio completo es similar a un entierro tradicional con la excepción de que el funeral ..."
            },
            new Package()
            {
                Id = 5,
                Image = "flower_silver.jpg",
                Title = "PACKETE FUNERARIO DE PLATA",
                Description = "El paquete funerario Plata para su ser querido."
            },
            new Package()
            {
                Id = 6,
                Image = "flower_gold.jpg",
                Title = "PACKETE FUNERARIO DE ORO",
                Description = "El paquete funerario Oro para su ser querido."
            },
            new Package()
            {
                Id = 7,
                Image = "flower_platinum.jpg",
                Title = "PACKETE FUNERARIO DE PLATINO",
                Description = "El paquete funerario Platino para su ser querido."
            },
        };
    }

}

public class Package
{
    public int Id { get; set; }
    public string Image { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
}