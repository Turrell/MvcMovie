﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
       //
       // GET: /HelloWorld/
       public string Index()
        {
            return "This is my defualt action";
        }

        //
        // GET: /HelloWorld/Welcome/
        public string Welcome(string name, int ID = 1)
        {
            return HtmlEncoder.Default.Encode($"Hello {nameof}, ID: {ID}" ;
        }
    }
}
