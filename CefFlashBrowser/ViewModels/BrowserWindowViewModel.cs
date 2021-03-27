﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using CefFlashBrowser.Models;

namespace CefFlashBrowser.ViewModels
{
    class BrowserWindowViewModel : NotificationObject
    {
        private string _title;

        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                RaisePropertyChanged("Title");
            }
        }

        private string _url;

        public string Url
        {
            get => _url;
            set
            {
                _url = value;
                RaisePropertyChanged("Url");

                if (string.IsNullOrEmpty(Title))
                    Title = value;
            }
        }

        public void TitleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            Title = e.NewValue.ToString();
        }
    }
}
