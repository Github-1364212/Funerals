namespace Funerals.Views;

public partial class ProductPage : ContentPage
{
    public List<Product> Products { get; set; }

    public ProductPage()
	{
		InitializeComponent();
        LoadData();
        BindingContext = this;

    }

    private void LoadData()
    {
        Products = new List<Product>
        {
            new Product()
            {
                Id = 1,
                Image = "flower_white.jpg",
                Title = "FUNERALS SIMPLE: PAQUETE DE ENTIERRO PREVIO A LA NECESIDAD",
                Description = "Nuestro sencillo paquete de env�o de entierro previo a la necesidad es para aquellos que desean que el entierro se lleve a cabo ..."
            },
            new Product()
            {
                Id = 2,
                Image = "envase_cremacion.jpg",
                Title = "FUNERALS CREMACION SIMPLE: PAQUETE DE CREMACION PREVIA A LA NECESIDAD",
                Description = "Nuestro sencillo paquete de env�o de cremaci�n previa a la necesidad es para aquellos que desean que la cremaci�n se lleve a cabo ..."
            },
            new Product()
            {
                Id = 3,
                Image = "custom_cremation.jpg",
                Title = "FUNERALS PERSONALIZAR: PAQUETE DE CREMACION PREVIA A LA NECESIDAD DE CONCIERGADO",
                Description = "Nuestro paquete de cremaci�n previa a la necesidad de env�o personalizado es para aquellos que desean ofrecer una cremaci�n de servicio ..."
            },
            new Product()
            {
                Id = 4,
                Image = "funeral_custom.jpg",
                Title = "FUNERALS PERSONALIZAR: PAQUETE DE FUNERARIO PRENECESIDAD CONCIERGADO",
                Description = "Nuestro paquete personalizado de funeral de prenecesidad de env�o es para aquellos que desean tener un funeral completo, digno ..."
            },
        };
    }

}

public class Product
{
    public int Id { get; set; }
    public string Image { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
}