using Microsoft.EntityFrameworkCore;

namespace DemoMVCReverseEngineering.Services;

public class SQLServerNorthwindData : INorthwindData
{
    private readonly NorthwindContext northwindContext;

    public SQLServerNorthwindData(NorthwindContext northwindContext)
    {
        this.northwindContext = northwindContext;
    }

    public async Task<IndexHomeViewModel> GetHomeIndexViewModelAsync()
    {
        var viewModel = new IndexHomeViewModel();

        viewModel.Cards.Add( new CardViewModel
        {
             Description = "Descrizione Prodotti",
             Quantity = await northwindContext.Products.CountAsync(),
             Title = "Prodotti"
        });

        viewModel.Cards.Add(new CardViewModel
        {
            Description = "Descrizione Categorie",
            Quantity = await northwindContext.Categories.CountAsync(),
            Title = "Categorie"
        });

        viewModel.Cards.Add(new CardViewModel
        {
            Description = "Descrizione Clienti",
            Quantity = await northwindContext.Customers.CountAsync(),
            Title = "Clienti"
        });

        viewModel.Cards.Add(new CardViewModel
        {
            Description = "Descrizione Ordini",
            Quantity = await northwindContext.Orders.CountAsync(),
            Title = "Ordini"
        });


        return viewModel;
    }
}
