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
                Title = "�C�MO UTILIZO ESTA APLICACI�N?",
                Description = "Funerals est� dise�ado con los primeros principios del usuario y es muy f�cil de usar."
            },
            new Help()
            {
                Id = 2,
                Image = "better_funeral.jpg",
                Title = "�POR QU� ES MEJOR QUE USAR UNA FUNERARIA TRADICIONAL?",
                Description = "Funerals es \"una mejor manera de hacer un funeral\" cualquier cosa... el servicio, seguro, financiaci�n, etc"
            },
            new Help()
            {
                Id = 3,
                Image = "reliable_providers.jpg",
                Title = "�C�MO S� QUE LOS PROVEEDORES DE SERVICIOS SON CONFIABLES?",
                Description = "Examinamos a proveedores de servicios para asegurarnos de que cumplan altos est�ndares de cumplimiento, ..."
            },
            new Help()
            {
                Id = 4,
                Image = "book_funeral.jpg",
                Title = "�PUEDO RESERVAR UN FUNERAL CON PREVIA?",
                Description = "S�, como novedad mundial, Funerals le permite planificar previamente y reservar todo su funeral."
            },
            new Help()
            {
                Id = 5,
                Image = "more_expensive.jpg",
                Title = "�NO ES ESTO M�S CARO?",
                Description = "No. Hemos recorrido el mercado para encontrar el mejor valor y los mejores servicios que pueda obtener."
            },
            new Help()
            {
                Id = 6,
                Image = "cash_delivery.jpg",
                Title = "�ACEPTAN CONTRA REEMBOLSO?",
                Description = "No. Solo aceptamos tarjetas de d�bito, tarjetas de cr�dito y dep�sitos EFT."
            },
            new Help()
            {
                Id = 7,
                Image = "check_progress.jpg",
                Title = "�C�MO COMPROBAR EL PROGRESO DEL SERVICIO?",
                Description = "Cada uno de nuestros clientes tiene un asesor funerario personal."
            },
            new Help()
            {
                Id = 8,
                Image = "available_location.jpg",
                Title = "�EST� DISPONIBLE LA DESPEDIDA EN MI UBLICACI�N?",
                Description = "Estamos disponibles para todos los servicios a nivel nacional viene incluido los paquetes funerarios."
            },
            new Help()
            {
                Id = 9,
                Image = "better_better.jpg",
                Title = "�POR QU� FUNERALS ES UNA MEJOR MANERA DE REALIZAR UN FUNERAL?",
                Description = "Hacemos todo por usted y ofrecemos un servicio completo de conserjer�a mientras usted se concentra en ..."
            },
            new Help()
            {
                Id = 10,
                Image = "account.jpg",
                Title = "C�MO INICIAR SESI�N",
                Description = "Cuando seleccione la secci�n de cuenta o al ejecutar la aplicaci�n, se le pedir� que inicie sesi�n."
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