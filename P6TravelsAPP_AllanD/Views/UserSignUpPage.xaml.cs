using P6TravelsAPP_AllanD.ViewModels;

namespace P6TravelsAPP_AllanD.Views;

public partial class UserSignUpPage : ContentPage
{
	//definici�n del objeto viewmodel que gestiona la p�gina 

	UserViewModel? vm;

	public UserSignUpPage()
	{
		InitializeComponent();

		BindingContext = vm = new UserViewModel();

		LoadUserRolesList();
	}

	private async void LoadUserRolesList()
	{
		LstUserRoles.ItemsSource = await vm.VmGetUserRolesAsync();
    }

    private async void BtnCancel_Clicked(object sender, EventArgs e)
    {
		await Navigation.PopAsync();
    }
}