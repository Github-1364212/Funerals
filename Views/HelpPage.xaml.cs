namespace Funerals.Views;

public partial class HelpPage : ContentPage
{
	public List<Help> Helps { get; set; }
    public HelpPage()
	{
		InitializeComponent();
        LoadData();
        BindingContext = this;
	}

    private void LoadData()
    {
        Helps = new List<Help>
        {
            new Help()
            {
                Id = 1,
                Image = "use_aplication.jpg",
                Title = "¿CÓMO UTILIZO ESTA APLICACIÓN?",
                Description = "Funerals está diseñado con los primeros principios del usuario y es muy fácil de usar."
            },
            new Help()
            {
                Id = 2,
                Image = "better_funeral.jpg",
                Title = "¿POR QUÉ ES MEJOR QUE USAR UNA FUNERARIA TRADICIONAL?",
                Description = "Funerals es \"una mejor manera de hacer un funeral\" cualquier cosa... el servicio, seguro, financiación, etc"
            },
            new Help()
            {
                Id = 3,
                Image = "reliable_providers.jpg",
                Title = "¿CÓMO SÉ QUE LOS PROVEEDORES DE SERVICIOS SON CONFIABLES?",
                Description = "Examinamos a proveedores de servicios para asegurarnos de que cumplan altos estándares de cumplimiento, ..."
            },
            new Help()
            {
                Id = 4,
                Image = "book_funeral.jpg",
                Title = "¿PUEDO RESERVAR UN FUNERAL CON PREVIA?",
                Description = "Sí, como novedad mundial, Funerals le permite planificar previamente y reservar todo su funeral."
            },
            new Help()
            {
                Id = 5,
                Image = "more_expensive.jpg",
                Title = "¿NO ES ESTO MÁS CARO?",
                Description = "No. Hemos recorrido el mercado para encontrar el mejor valor y los mejores servicios que pueda obtener."
            },
            new Help()
            {
                Id = 6,
                Image = "cash_delivery.jpg",
                Title = "¿ACEPTAN CONTRA REEMBOLSO?",
                Description = "No. Solo aceptamos tarjetas de débito, tarjetas de crédito y depósitos EFT."
            },
            new Help()
            {
                Id = 7,
                Image = "check_progress.jpg",
                Title = "¿CÓMO COMPROBAR EL PROGRESO DEL SERVICIO?",
                Description = "Cada uno de nuestros clientes tiene un asesor funerario personal."
            },
            new Help()
            {
                Id = 8,
                Image = "available_location.jpg",
                Title = "¿ESTÁ DISPONIBLE LA DESPEDIDA EN MI UBLICACIÓN?",
                Description = "Estamos disponibles para todos los servicios a nivel nacional viene incluido los paquetes funerarios."
            },
            new Help()
            {
                Id = 9,
                Image = "better_better.jpg",
                Title = "¿POR QUÉ FUNERALS ES UNA MEJOR MANERA DE REALIZAR UN FUNERAL?",
                Description = "Hacemos todo por usted y ofrecemos un servicio completo de conserjería mientras usted se concentra en ..."
            },
            new Help()
            {
                Id = 10,
                Image = "account.jpg",
                Title = "CÓMO INICIAR SESIÓN",
                Description = "Cuando seleccione la sección de cuenta o al ejecutar la aplicación, se le pedirá que inicie sesión."
            },
        };
    }
}

public  class Help
{
    public int Id { get; set; }
    public string Image { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
}