using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BTL_WEB
{
    public class Member
    {
        int id;
        string email;
        string ten;
        string pass;
        string doituong;
        string sdt;

        public int ID { get => id; set => id = value; }
        public string Email { get => email; set => email = value; }
        public string Ten { get => ten; set => ten = value; }
        public string Pass1 { get => pass; set => pass = value; }
        public string Doituong { get => doituong; set => doituong = value; }
        public string Sdt { get => sdt; set => sdt = value; }

    }
}