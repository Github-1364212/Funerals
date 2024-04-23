namespace Funerals.Views;

public partial class PoliciePage : ContentPage
{
    public List<Policie> Policies { get; set; }

    public PoliciePage()
	{
		InitializeComponent();
        LoadData();
        BindingContext = this;
    }

    private void LoadData()
    {
        Policies = new List<Policie>
        {
            new Policie()
            {
                Id = 1,
                Image = "family_happy.jpg",
                Title = "PLAN FAMILAR INMEDIATA ZAZU",
                Description = "¿Un plan con todos los beneficios adicionales que cubren a toda la familia?"
            },
            new Policie()
            {
                Id = 2,
                Image = "top_plan.jpg",
                Title = "PLAN DE RECARGA FUNERALS",
                Description = "¿Necesita cobertura adicional? La vida de Funerals, te tiene cubierto. Recarga y ..."
            },
            new Policie()
            {
                Id = 3,
                Image = "extended_family.jpg",
                Title = "PLAN FAMILIA EXTENDIDA FUNERALS",
                Description = "Tios y primos de la familia, no nos hemos olvidado de ustedes."
            },
            new Policie()
            {
                Id = 4,
                Image = "single_member.png",
                Title = "PLAN INTEGRAL DEFINITIVO: MIEMBRO ÚNICO 18-69",
                Description = "El Plan Funerario Integral Definitivo para un afiliado de 18 a 69 años."
            },
            new Policie()
            {
                Id = 5,
                Image = "member_member.jpg",
                Title = "PLAN INTEGRAL DEFINITIVO: MIEMBRO DE MI FAMILIA",
                Description = "El mejor plan funerario integral: miembro + familia."
            },
            new Policie()
            {
                Id = 6,
                Image = "family_member.jpg",
                Title = "PLAN INTEGRAL DEFINTIVO: FAMILIA EXTENDIDA 0-65",
                Description = "El plan funerario integral definitivo: familia extendida."
            },
            new Policie()
            {
                Id = 7,
                Image = "ancient_member.jpg",
                Title = "PLAN INTEGRAL DEFINITIVO: FAMILIA EXTENDIDA 66-75",
                Description = "El plan funerario integral definitivo: familia extendida."
            },
            new Policie()
            {
                Id = 8,
                Image = "post_ancient_member.jpg",
                Title = "PLAN INTEGRAL DEFINITIVO: FAMILIA EXTENDIDA 76-85",
                Description = "El plan funerario integral definitivo: familia extendida."
            },
        };
    }

}

public class Policie
{
    public int Id { get; set; }
    public string Image { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
}