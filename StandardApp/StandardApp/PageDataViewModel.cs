using System;
using System.Collections.Generic;
using System.Text;

namespace StandardApp
{
    class PageDataViewModel
    {
        public PageDataViewModel(Type type, string title, string description)
        {
            Type = type;
            Title = title;
            Description = description;
        }

        public Type Type { private set; get; }

        public string Title { private set; get; }

        public string Description { private set; get; }

        static PageDataViewModel()
        {
            All = new List<PageDataViewModel>
            {
                // Part 1. Getting Started with XAML
                new PageDataViewModel(typeof(HelloPage), "Hello, XAML",
                                      "Display a Label with many properties set"),

                new PageDataViewModel(typeof(XamlAndCode), "XAML + Code",
                                      "Interact with a Slider and Button"),

                // Part 2. Essential XAML Syntax
                new PageDataViewModel(typeof(GridDemo), "Grid Demo",
                                      "Explore XAML syntax with the Grid"),

                new PageDataViewModel(typeof(AbsoluteDemo), "Absolute Demo",
                                      "Explore XAML syntax with AbsoluteLayout"),

                // Part 3. XAML Markup Extensions
                new PageDataViewModel(typeof(SharedResourcesPage), "Shared Resources",
                                      "Using resource dictionaries to share resources"),

                new PageDataViewModel(typeof(StaticConstantsPage), "Static Constants",
                                      "Using the x:Static markup extensions"),

                // Part 4. Data Binding Basics
                new PageDataViewModel(typeof(SliderBindingsPage), "Slider Bindings",
                                      "Bind properties of two views on the page"),

                new PageDataViewModel(typeof(SliderTransformPage), "Slider Transforms",
                                      "Use Sliders with reverse bindings"),

                new PageDataViewModel(typeof(ListViewDemoPage), "ListView Demo",
                                      "Use a ListView with data bindings"),

            };
        }

     public static IList<PageDataViewModel> All { private set; get; }
    }
}
