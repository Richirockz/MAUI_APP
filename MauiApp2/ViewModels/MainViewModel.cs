using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Net.Mime;
using System.Windows.Input;
using Android.Content;
using AndroidX.Lifecycle.ViewModels;
using CommunityToolkit.Mvvm.ComponentModel;
using Kotlin.Properties;


namespace MauiApp2.ViewModels;

public partial class MainViewModel : ObservableObject
{
    public MainViewModel()
    {
        items = new ObservableColletion<string>();
    }
   
    [ObservableProperty]
    private ObservableCollection<string> items;

    [ObservableProperty] 
    private string text;

    [ICommand]
    void Add()
    {
        if (string.IsNullOrWhiteSpace(Text))
            return;

        Items.Add(Text);
        //add our Item
        Text = string.Empty;

        [ICommand]
        void Delete(string s)
        {
            if (items.Contains(s))
            {
                items.Remove(s);
            }
            
        }

    }
