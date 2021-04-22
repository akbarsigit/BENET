using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BENETproto
{
    public class Place : Sport
    {
        public string placeName;
        public string placeType;
        public string CurrentPosition;
        public string Address;
        public string PhoneNumber;
        public string GetSportName()
        {
            return this.SportName;
        }
        public string PlaceName
        {
            get
            {
                return placeName;
            }
            set
            {
                placeName = value;
            }
        }
        public string PlaceType
        {
            get
            {
                return placeType;
            }
            set
            {
                placeType = value;
            }
        }
        public string GetCurrentPosition()
        {
            return this.CurrentPosition;
        }
        public string GetAddress()
        {
            return this.Address;
        }
        public string GetPhoneNumber()
        {
            return this.PhoneNumber;
        }
    }
}
