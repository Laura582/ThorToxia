using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using ThorToxia.Models;

namespace ThorToxia.ViewModel
{
    public partial class FoodListViewModel
    {

       public static List<SearchModel> Search { get; private set; } = new List<SearchModel>();
        public FoodListViewModel()
        {
            Search.Add(new SearchModel
            {
                Name = "Apple",
                Danger = "No"
            });
            Search.Add(new SearchModel
            {
                Name = "Chocolate",
                Danger = "Yes"
            });
            Search.Add(new SearchModel
            {
                Name = "Chocolate",
                Danger = "Yes"
            });
        }

    }
}
