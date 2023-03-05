using System;

namespace CityEvents.Models
{
    public class CityEvent
    {
        private string _imgLink = "";
        private string _title = "";
        private string _date = "";
        private string _description = "";
        private float _price = 0;
        private ushort _maxPrintLength = 135;

        public string ImgLink
        {
            get => _imgLink;
            set => _imgLink = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string Title
        {
            get => _title;
            set => _title = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string Date
        {
            get => _date;
            set => _date = value ?? throw new ArgumentNullException(nameof(value));
        }

        public string Description
        {
            get
            {
                if (_description.Length > _maxPrintLength)
                    return _description.Substring(0, _maxPrintLength) + "...";
                
                return _description;
            }
            set => _description = value ?? throw new ArgumentNullException(nameof(value));
        }
        
        public string FullDescription
        {
            get => _description;
            set => _description = value ?? throw new ArgumentNullException(nameof(value));
        }

        public float Price
        {
            get => _price;
            set => _price = value;
        }
    }
}