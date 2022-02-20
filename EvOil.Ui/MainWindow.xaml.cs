using EvOil.Business;
using System.Windows;
using EvOil.Persistence;
using EvOil.Domain.Models;
using EvOil.Business.Services.Implementations;
using System;

namespace EvOil.Ui;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public readonly UserService _databaseContextUser;
    public MainWindow()
    {
        // InitializeComponent();
        // var db = EvOilDatabaseContextFactory.Create(args);
        // _databaseContextUser = new UserService(db);

    }
    private void CreateUserButton(object sender, RoutedEventArgs e)
    {
        // var name = this.setUserName.Text;
        // var password = this.SetUserPassword.Text;
        // _ = _databaseContextUser.SetUser(new User() { Name = name, Password = password });

    }
    private void GetUserIdButton(object sender, RoutedEventArgs e)
    {
        // var name = this.UserNameForId.Text;
        // var user = _databaseContextUser.GetUser(name);
        // var nameId = user.Id;
        // this.UserId.Text = $"{nameId}";
    }

}
