using System;
using System.Collections.Generic;
using System.Text;

namespace Application.ViewModels.VML
{
    public class ViewModelLocator
    {
        public MainViewModel MainViewModel => Ioc.Resolve<MainViewModel>();
    }
}
