using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinApp
{
    class Page : Xamarin.Forms.Page
    {
        TabbedPage tabbed = new TabbedPage();
        ContentPage travelTab;
        ContentPage lineTab;

        List<String> l = new List<String>();
        List<String> s = new List<String>();

        public Page()
        {

            l.Add("1");
            l.Add("2");
            l.Add("3");

            s.Add("prva");
            s.Add("druga");
            s.Add("treca");
            s.Add("cetvrta");
            s.Add("peta");

            tabbed.Children.Add(new TravelTab(l,s));
            tabbed.Children.Add(new LineTab(l, s));

            tabbed.IsVisible = true;
        }

        private class TravelTab : ContentPage
        {
            ScrollView scrollView;

            public TravelTab(List<String> l, List<String> s)
            {
                scrollView = new ScrollView();
                StackLayout layout = new StackLayout();

                Picker linija = new Picker();
                Picker pocStanica = new Picker();
                Picker zavStanica = new Picker();
                TimePicker vrijeme = new TimePicker();

                linija.ItemsSource = l;
                pocStanica.ItemsSource = s;
                zavStanica.ItemsSource = s;
                vrijeme.Time = DateTime.Now.TimeOfDay;

                layout.Children.Add(linija);
                layout.Children.Add(pocStanica);
                layout.Children.Add(zavStanica);
                layout.Children.Add(vrijeme);

                scrollView.Content = layout;

            }
        }

        private class LineTab : ContentPage
        {
            ScrollView scrollView;

            public LineTab(List<String> l, List<String> s)
            {
                scrollView = new ScrollView();
                StackLayout layout = new StackLayout();
                Picker linija = new Picker();
                ListView listView = new ListView();

                linija.ItemsSource = l;

                listView.ItemsSource = s;

                layout.Children.Add(linija);
                layout.Children.Add(listView);

                scrollView.Content = layout;
            }
        }
    }
}
