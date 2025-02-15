﻿using System.Windows;
using Aleepartners.CarFleetManagement.Models;
using Aleepartners.CarFleetManagement.Views;

namespace Aleepartners.CarFleetManagement
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            return ContainerLocator.Container.Resolve<MainView>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // Register services and views for navigation
            containerRegistry.Register<IDataManager, DataManager>();  
            containerRegistry.RegisterForNavigation<MainView>();

        }
    }

}
