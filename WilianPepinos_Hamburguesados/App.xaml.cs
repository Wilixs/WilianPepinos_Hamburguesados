﻿using WilianPepinos_Hamburguesados.Data;

namespace WilianPepinos_Hamburguesados;

public partial class App : Application
{

    public static BurgerDatabase BurgerRepo { get; private set; }

    public App(BurgerDatabase repo)
    {
        InitializeComponent();

        MainPage = new AppShell();

        BurgerRepo = repo;
    }
}
