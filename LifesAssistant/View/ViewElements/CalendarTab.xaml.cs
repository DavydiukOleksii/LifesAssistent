﻿using System.Globalization;
using System.Threading;
using System.Windows.Controls;
using System.Windows.Markup;
using LifesAssistant.ViewModel;
using LifesAssistant.ViewModel.ViewModelElements;

namespace LifesAssistant.View.ViewElements
{
    /// <summary>
    /// Interaction logic for CalendarTab.xaml
    /// </summary>
    public partial class CalendarTab : UserControl
    {
        public CalendarTab()
        {
            this.Language = XmlLanguage.GetLanguage(
                        Thread.CurrentThread.CurrentUICulture.IetfLanguageTag);
            InitializeComponent();
        }
    }
}
