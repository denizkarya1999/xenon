using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; //To use eannotations such as Key, Required
using System.Linq;
using System.Threading.Tasks;

namespace Zenon___Contact_Management_System.Data
{
    public class Contact
    {
        //Store all CRUD Operations
        [Key]
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string PhoneNumber { get; set; }
        public string BirthDate { get; set; }
    }

}