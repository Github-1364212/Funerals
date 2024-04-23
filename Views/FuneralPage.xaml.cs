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
                Description = "Respira... T�mate un minuto. Siempre ..."
            },
            new Funeral()
            {
                Id = 2,
                Image = "pickup.jpg",
                Title = "LEVANTAR",
                Description = "Ya sea que su ser querido est� en un ..."
            },
            new Funeral()
            {
                Id = 3,
                Image = "collection.jpg",
                Title = "RECOGIDA DE DOCUMENTOS",
                Description = "Deber� obtener: el \"Aviso de defun..."
            },
            new Funeral()
            {
                Id = 4,
                Image = "notification.jpg",
                Title = "NOTIFICACIONES FAMILIARES",
                Description = "Deber� notificar al menos a la familia ..."
            },
            new Funeral()
            {
                Id = 5,
                Image = "start.jpg",
                Title = "INICIA EL PROCESO DE RECLAMACIONES DE SEGURO DE VIDA Y FUNERARIO",
                Description = "Deber� reclamar cualquier p�liza que ..."
            },
            new Funeral()
            {
                Id = 6,
                Image = "choose.png",
                Title = "ELIJA UN FUNERAL O CREMACI�N",
                Description = "�Su ser querido quer�a un funeral o ..."
            },
            new Funeral()
            {
                Id = 7,
                Image = "coffin.jpg",
                Title = "ELIGE UN ATA�D O URNA",
                Description = "Tendr�s que elegir un ata�d o urna."
            },
            new Funeral()
            {
                Id = 8,
                Image = "church.jpg",
                Title = "RESERVAR IGLESIA/MEZQUITA/SHUL PARA SERVICIO",
                Description = "Deber� reservar un lugar para ..."
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
                Description = "Deber� decidir y reservar arreglos ..."
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