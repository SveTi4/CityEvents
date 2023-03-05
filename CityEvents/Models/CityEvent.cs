using System;
using DynamicData.Binding;

namespace CityEvents.Models
{
    public class CityEvent: AbstractNotifyPropertyChanged
    {
        private string _imgLink = "";
        private string _title = "";
        private string _date = "";
        private string _description = "";
        private float _price = 0;
        private Category _category;
        private ushort _maxPrintLength = 135;

        public string ImgLink
        {
            get => _imgLink;
            set => SetAndRaise(ref _imgLink, value);
        }

        public string Title
        {
            get => _title;
            set => SetAndRaise(ref _title, value);
        }

        public string Date
        {
            get => _date;
            set => SetAndRaise(ref _date, value);
        }

        public string Description
        {
            get
            {
                if (_description.Length > _maxPrintLength)
                    return _description.Substring(0, _maxPrintLength) + "...";
                
                return _description;
            }
            set => SetAndRaise(ref _description, value);
        }
        
        public string FullDescription
        {
            get => _description;
            set => SetAndRaise(ref _description, value);
        }

        public float Price
        {
            get => _price;
            set => SetAndRaise(ref _price, value);
        }
        public Category Category
        {
            get => _category;
            set => SetAndRaise(ref _category, value);
        }
    }
}