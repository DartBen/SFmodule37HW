using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SFmodule37.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WeatherPage : ContentPage
    {
        public WeatherPage()
        {

            Grid grid = new Grid
            {
                // Набор строк 
                RowDefinitions =
               {
                   new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                   new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                   new RowDefinition { Height = new GridLength(1, GridUnitType.Star) }
               },

                // Набор столбцов
                ColumnDefinitions =
               {
                   new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
               }
            };
            grid.BackgroundColor = Color.Black;
            // Добавление элементов по определенным позициям
            grid.Children.Add(new BoxView { Color = Color.FromRgb(244, 164, 96) }, 0, 0);
            grid.Children.Add(new BoxView { Color = Color.FromRgb(0, 255, 255) }, 0, 1);
            grid.Children.Add(new BoxView { Color = Color.FromRgb(0, 128, 128) }, 0, 2);

            // Добавление меток
            int level = 0;
            AddLabel(grid, level, "\nInside", 50, TextAlignment.Start, TextAlignment.Center);
            AddLabel(grid, level, "+26 °C", 80, TextAlignment.End, TextAlignment.Center);
            level = 1;
            AddLabel(grid, level, "\nOutside", 50, TextAlignment.Start, TextAlignment.Center);
            AddLabel(grid, level, "-16 °C", 80, TextAlignment.End, TextAlignment.Center);
            level = 2;
            AddLabel(grid, level, "\nPressure", 50, TextAlignment.Start, TextAlignment.Center);
            AddLabel(grid, level, "760 mm", 80, TextAlignment.End, TextAlignment.Center);


            Content = grid;
        }

        public void AddLabel(Grid grid, int level, string text, int fontSize, TextAlignment textAlignmentVertical, TextAlignment textAlignmentHorizontal)
        {
            grid.Children.Add(
                new Label
                {
                    Text = text,
                    VerticalTextAlignment = textAlignmentVertical,
                    HorizontalTextAlignment = textAlignmentHorizontal,
                    FontSize = fontSize,
                    TextColor =Color.Black
                },
                0, level);
        }

    }
}