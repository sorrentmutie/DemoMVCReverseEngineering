namespace DemoMVCReverseEngineering.ViewModels;

public class IndexHomeViewModel
{
//    public int NumberOfCategories { get; set; }
//    public int NumberOfProducts { get; set; }
//    public int NumberOfCustomers{ get; set; }
//    public int NumberOfOrders { get; set; } 

    //public CardViewModel CategoriesCard { get; set; } = new CardViewModel();
    //public CardViewModel ProductsCard { get; set; } = new CardViewModel();
    //public CardViewModel CustomersCard { get; set; } = new CardViewModel();
    //public CardViewModel OrdersCard { get; set; } = new CardViewModel();

    public List<CardViewModel> Cards { get; set; } = new List<CardViewModel>(); 


}
