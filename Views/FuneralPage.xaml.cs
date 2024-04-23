namespace Funerals.Views;

public partial class FuneralPage : ContentPage
{
    public List<Funeral> Funerals { get; set; }

    public FuneralPage()
	{
		InitializeComponent();
        LoadData();
        BindingContext = this;

    }

    private void LoadData()
    {
        Funerals = new List<Funeral>
        {
            new Funeral()
            {
                Id = 1,
                Image = "breathe.jpg",
                Title = "RESPIRAR",
                Description = "Respira... Tómate un minuto. Siempre ..."
            },
            new Funeral()
            {
                Id = 2,
                Image = "pickup.jpg",
                Title = "LEVANTAR",
                Description = "Ya sea que su ser querido esté en un ..."
            },
            new Funeral()
            {
                Id = 3,
                Image = "collection.jpg",
                Title = "RECOGIDA DE DOCUMENTOS",
                Description = "Deberá obtener: el \"Aviso de defun..."
            },
            new Funeral()
            {
                Id = 4,
                Image = "notification.jpg",
                Title = "NOTIFICACIONES FAMILIARES",
                Description = "Deberá notificar al menos a la familia ..."
            },
            new Funeral()
            {
                Id = 5,
                Image = "start.jpg",
                Title = "INICIA EL PROCESO DE RECLAMACIONES DE SEGURO DE VIDA Y FUNERARIO",
                Description = "Deberá reclamar cualquier póliza que ..."
            },
            new Funeral()
            {
                Id = 6,
                Image = "choose.png",
                Title = "ELIJA UN FUNERAL O CREMACIÓN",
                Description = "¿Su ser querido quería un funeral o ..."
            },
            new Funeral()
            {
                Id = 7,
                Image = "coffin.jpg",
                Title = "ELIGE UN ATAÚD O URNA",
                Description = "Tendrás que elegir un ataúd o urna."
            },
            new Funeral()
            {
                Id = 8,
                Image = "church.jpg",
                Title = "RESERVAR IGLESIA/MEZQUITA/SHUL PARA SERVICIO",
                Description = "Deberá reservar un lugar para ..."
            },
            new Funeral()
            {
                Id = 9,
                Image = "transportation.jpg",
                Title = "ORGANIZAR EL TRANSPORTE PARA FAMILIARES",
                Description = "Es costumbre reservar transporte ..."
            },
            new Funeral()
            {
                Id = 10,
                Image = "book_flowers.jpg",
                Title = "RESERVAR FLORES Y ARREGLO SELECCIONADO",
                Description = "Deberá decidir y reservar arreglos ..."
            },
        };
    }

}

public class Funeral
{
    public int Id { get; set; }
    public string Image { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
}