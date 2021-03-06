﻿using Projectono.Application.ViewModels;
using Projectono.Environment;
using Projectono.Environment.Adaptors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

using Xamarin.Forms;

namespace Projectono.App
{
	public partial class App : Xamarin.Forms.Application
	{
        private IIocContainer _container;
        private Application.ViewModels.Application _application;

		public App ()
		{
			InitializeComponent();

            _container = new IocContainer();
            Bootstrap.ReflectDependencies(_container, typeof(App).GetTypeInfo().Assembly);
            
			MainPage = new MainPage {
                BindingContext = _application = Bootstrap.StartApplication(_container)
            };
		}

		protected override void OnStart ()
		{

        }

        protected override void OnSleep ()
		{

		}

		protected override void OnResume ()
		{

		}
	}
}
