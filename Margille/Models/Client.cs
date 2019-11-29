using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Margille.Models
{
    public class Client
    {
        public int ClientId { get; set; }
        [Required]
        [MaxLength(66, ErrorMessage = "Max 66 caracteres"), MinLength(5, ErrorMessage = "Min 5 caracteres")]
        public string NameClient { get; set; }
        public string Email { get; set; }
        [Required]
        public int Mobile { get; set; }
        public string Pwd { get; set; }
        [Required]
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        [Required]
        public string PostCode { get; set; }
        public bool Staff { get; set; }


        public Client()
        {
        }

        public Client(int id, string name, string email, int mobile, string pwd, string add1, string add2, string add3, string postcode)
        {
            ClientId = id;
            NameClient = name;
            Email = email;
            Mobile = mobile;
            Pwd = pwd;
            AddressLine1 = add1;
            AddressLine2 = add2;
            AddressLine3 = add3;
            PostCode = postcode;
        }

        public Client(string name, string email, int mobile, string pwd, string add1, string add2, string add3, string postcode)
        {
            NameClient = name;
            Email = email;
            Mobile = mobile;
            Pwd = pwd;
            AddressLine1 = add1;
            AddressLine2 = add2;
            AddressLine3 = add3;
            PostCode = postcode;
        }
    }
}