﻿using WinToys.ViewModels;
using Wpf.Ui.Common.Interfaces;

namespace WinToys.Views.Pages;

/// <summary>
/// Interaction logic for SettingsPage.xaml
/// </summary>
public partial class SettingsPage : INavigableView<SettingsViewModel>
{
    public SettingsViewModel ViewModel
    {
        get;
    }

    public SettingsPage(SettingsViewModel viewModel)
    {
        ViewModel = viewModel;

        InitializeComponent();
    }
}