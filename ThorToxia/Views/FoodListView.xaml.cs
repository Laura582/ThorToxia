using ThorToxia.ViewModel;

namespace ThorToxia.View;

public partial class FoodListView : ContentPage
{
	public FoodListView()
	{
        InitializeComponent();
        this.BindingContext = new FoodListViewModel();
    }

}