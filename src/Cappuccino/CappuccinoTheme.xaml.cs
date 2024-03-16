using System;
using Avalonia.Markup.Xaml;
using Avalonia.Styling;

namespace Cappuccino
{
    public class CappuccinoTheme : Styles
    {
        public CappuccinoTheme(IServiceProvider? sp = null)
        {
            AvaloniaXamlLoader.Load(sp, this);
        }
    }
}