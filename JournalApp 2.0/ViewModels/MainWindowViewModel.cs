using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JournalApp.ViewModels.Base;


namespace JournalApp.ViewModels
{
    internal class MainWindowViewModel: ViewModel
    {
        private string title;

        /// <summary>Заголовок окна </summary>
        
        public string Title
        {
            get { return title; }
            set { Set(ref title, value); }
        }
    }
}
