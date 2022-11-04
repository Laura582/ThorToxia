using ThorToxia.Models;

namespace ThorToxia.SearchHandler
{
    public class FoodSearchHandler : Microsoft.Maui.Controls.SearchHandler
    {
        public IList<SearchModel> Search { get; set; }

        protected override void OnQueryChanged(string oldValue, string newValue)
        {
            base.OnQueryChanged(oldValue, newValue);
            if(string.IsNullOrEmpty(newValue))
            {
                ItemsSource = null;
            }
            else
            {
                ItemsSource = Search.Where(food => food.Name.ToLower().Contains(newValue.ToLower())).ToList();
            }

        }
        protected override void OnItemSelected(object item)
        {
            base.OnItemSelected(item);
        }
    }
}
