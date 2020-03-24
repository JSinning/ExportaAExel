using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exportInforms.Class
{
    class PetitionUsersGet
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public address Address { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }
        public company Company { get; set; }
    }

    class address
    {
        public string Street { get; set; }
        public string Suite { get; set; }
        public string City { get; set; }
        public string Zipcode { get; set; }
        public geo GEO { get; set; }

    }
    class geo
    {
        public string LAT { get; set; }
        public string LNG { get; set; }
    }
    class company
    {
        public string Name { get; set; }
        public string CatchPhrase { get; set; }
        public string BS { get; set; }

    }
}
