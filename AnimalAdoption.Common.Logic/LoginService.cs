﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalAdoption.Common.Logic
{
    public class LoginService
    {
        public string[] GetLoginIds()
        {
            return new string[]
            {
                "pencil",
                "flower",
                "icecream",
                "basketball",
                "orange",
                "placeholder"
            };
        }

        public string GetLoginUserFromId(string id)
        {
            //switch name to convert from object to name
            string name = "";
            switch (id)
            {
                case "pencil":
                    name = "Dimas";
                    break;
                case "flower":
                    name = "Dimas again";
                    break;
                case "icecream":
                    name = "Dimas is awesome";
                    break;
                case "basketball":
                    name = "Logan";
                    break;
                case "orange":
                    name = "Murphy";
                    break;
                case "placeholder":
                    name = "carabao";
                    break;
            }
            return name;
        }
    }
}
