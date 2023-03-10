using WilianPepinos_Hamburguesados.Models;

namespace WilianPepinos_Hamburguesados.Views;

public partial class BurgerListPage : ContentPage
{
    public BurgerListPage()
    {
        InitializeComponent();
        List<Burger> burger = App.BurgerRepo.GetAllBurgers();
        burgerList.ItemsSource = burger;
        BindingContext = this;
    }
    async void OnItemAdded(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(BurgerItemPage), true, new Dictionary<string, object> { ["Item"] = new Burger() });
    }

    private void RefreshData(object sender, EventArgs e)
    {
        List<Burger> burger = App.BurgerRepo.GetAllBurgers();
        burgerList.ItemsSource = burger;
    }
    private void SelectedItem(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is not Burger Item)
            return;

        Shell.Current.GoToAsync(nameof(BurgerItemPage), true, new Dictionary<string, object> { ["Item"] = Item });
    }
}