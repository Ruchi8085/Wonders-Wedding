using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myproject.Models
{
    public class CaptchaGenerator
    {
        public string CaptchaCode()
        {
            char c1, c2, c3, c4, c5, c6;
            Random r = new Random();
            c1 = Convert.ToChar(r.Next(65, 92));
            c2 = Convert.ToChar(r.Next(98, 122));
            c3 = Convert.ToChar(r.Next(50, 55));
            c4 = Convert.ToChar(r.Next(65, 92));
            c5 = Convert.ToChar(r.Next(78, 85));
            c6 = Convert.ToChar(r.Next(51, 55));
            string captch = c1 + "" + c2 + "" + c3 + "" + c4 + "" + c5 + "" + c6;
            return captch;
        }
    }
}