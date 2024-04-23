namespace Funerals.Views;

public partial class HomePage : ContentPage
{
    public List<Home> Homes { get; set; }

    public HomePage()
	{
		InitializeComponent();
        LoadData();
        BindingContext = this;

    }

    private void LoadData()
    {
        Homes = new List<Home>
        {
            new Home()
            {
                Id = 1,
                Image = "panic_button.jpg",
                Title = "BOTÓN DE PÁNICO FUNERALS",
                Description = "No sabes qué hacer y necesitas que te llamemos inmediatamente."
            },
            new Home()
            {
                Id = 2,
                Image = "funeral_package.jpg",
                Title = "PAQUETES FUNERARIOS",
                Description = "Paquetes funerarios todo incluido: ¿Platino, Oro o Plata para su ser querido?"
            },
            new Home()
            {
                Id = 3,
                Image = "funeral_service.jpg",
                Title = "SERVICIOS FÚNEBRES",
                Description = "Selecciona un servicio: Recogida, ataúdes, flores, reserva de iglesia, cualquier cosa."
            },
            new Home()
            {
                Id = 4,
                Image = "less.jpg",
                Title = "GENERADOR DE VOLUNTAD",
                Description = "Ordene su testamento en 7 minutos o menos."
            },
            new Home()
            {
                Id = 5,
                Image = "checklist.jpg",
                Title = "LISTA DE VERIFICACIÓN FUNERARIA",
                Description = "Todas las tareas que necesitas realizar para el funeral"
            },
            new Home()
            {
                Id = 6,
                Image = "funeral_policies.jpg",
                Title = "POLÍTICAS FUNERARIAS",
                Description = "Cobertura integral en caso de fallecimiento"
            },
            new Home()
            {
                Id = 7,
                Image = "pre_plan.jpg",
                Title = "PLANIFICAR PREVIAMENTE UN FUNERAL",
                Description = "Planifique con anticipación y reserve todas las tareas que necesita realizar para el funeral."
            },
            new Home()
            {
                Id = 8,
                Image = "help_faq.jpg",
                Title = "AYUDA Y FAQ",
                Description = "Encuentre ayuda y preguntas frecuentes."
            },
        };
    }

}

public class Home
{
    public int Id { get; set; }
    public string Image { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
}