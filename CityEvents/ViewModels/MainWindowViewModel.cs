using System;
using CityEvents.Models;
using ReactiveUI;

namespace CityEvents.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private CityEvent[] _TabEvents;
        // private string _TabTitle;
        
        public MainWindowViewModel()
        {
            TabEvents = new CityEvent[]
            {
                new CityEvent(){Title= "Event title 1", Date = "12.04.2023", Description = " Lorem ipsum dolor sit " +
                    "amet, consectetur adipiscing elit. Duis in luctus urna. Morbi sit amet metus pellentesque, " +
                    "rhoncus urna sed, varius lacus. Interdum et malesuada fames ac ante ipsum primis in faucibus. " +
                    "Fusce tincidunt turpis odio, id condimentum odio convallis sed. Nulla facilisi. Aenean feugiat " +
                    "augue sit amet massa consectetur, nec tincidunt quam efficitur. Fusce aliquam urna dolor, eget " +
                    "dapibus nunc posuere non. Curabitur ipsum velit, sodales at scelerisque id, commodo vitae lorem. " +
                    "Curabitur bibendum ut elit vel egestas. Donec venenatis elit et sapien consequat faucibus. Duis " +
                    "gravida enim commodo pellentesque rutrum. Cras efficitur sapien augue, ut convallis odio finibus " +
                    "dignissim. Aliquam vitae leo elementum, hendrerit sem at, auctor elit. Nullam consequat tortor et " +
                    "erat tempor volutpat. Vivamus feugiat tortor vel urna gravida viverra. Curabitur sodales a arcu " +
                    "sit amet fermentum. ", Price = 0},
                new CityEvent(){Title= "Event title 2", Date = "08.03.2023",  Description = "Description 2", Price = 200},
                new CityEvent(){Title= "Event title 3", Date = "10.05.2023",  Description = "Description 3", Price = 100},
                new CityEvent(){Title= "Event title 4", Date = "01.06.2023",  Description = "Description 4", Price = 0},
            };
        }

        public CityEvent[] TabEvents { get => _TabEvents; set => this.RaiseAndSetIfChanged(ref _TabEvents, value); }
        // public string TabTitle { get => _TabTitle; set => this.RaiseAndSetIfChanged(ref _TabTitle, value); }
    }
}

