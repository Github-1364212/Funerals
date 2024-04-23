namespace Funerals.Views;

public partial class ServicePage : ContentPage
{
    public List<Service> Services { get; set; }

    public ServicePage()
	{
		InitializeComponent();
        LoadData();
        BindingContext = this;

    }
    private void LoadData()
    {
        Services = new List<Service>
        {
            new Service()
            {
                Id = 1,
                Image = "pickup_deceased.jpg",
                Title = "RECOGIDA DEL ...",
                // fallecido

            },
            new Service()
            {
                Id = 2,
                Image = "coffin.jpg",
                Title = "ATAÚDES",
            },
            new Service()
            {
                Id = 3,
                Image = "custom_cremation.jpg",
                Title = "CREMACIONES",
            },
            new Service()
            {
                Id = 4,
                Image = "church.jpg",
                Title = "RESERVA DE IGLESIA",
            },
            new Service()
            {
                Id = 5,
                Image = "flower_white.jpg",
                Title = "FLORES",
            },
            new Service()
            {
                Id = 6,
                Image = "transportation.jpg",
                Title = "TRANSPORTE",
            },
            new Service()
            {
                Id = 7,
                Image = "tombstones.jpg",
                Title = "LAPIDAS",
            },
            new Service()
            {
                Id = 8,
                Image = "pvt.jpg",
                Title = "PARQUES ...",
            },
            new Service()
            {
                Id = 9,
                Image = "repatriations.jpg",
                Title = "REPATRIACIONES",
            },
            new Service()
            {
                Id = 10,
                Image = "fhoto_video.jpg",
                Title = "FOTO/VÍDEO",
            },
            new Service()
            {
                Id = 11,
                Image = "mental_health.jpg",
                Title = "SALUD MENTAL",
            },
            new Service()
            {
                Id = 12,
                Image = "memorials.jpg",
                Title = "MONUMENTOS VIVOS",
            },
            new Service()
            {
                Id = 13,
                Image = "estates.jpg",
                Title = "PROPIEDADES ...",
                // del fallecido
            },
            new Service()
            {
                Id = 14,
                Image = "urn.jpg",
                Title = "URNAS",
            },
        };
    }

}

public class Service
{
    public int Id { get; set; }
    public string Image { get; set; }
    public string Title { get; set; }
}