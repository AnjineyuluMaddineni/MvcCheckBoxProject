using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcCheckBoxProject.ViewModel
{
    public class Fruits
    {
        public int fruitId { get; set; }
        public string fruitName { get; set; }
        public bool isCheck { get; set; }
    }
    public class FruitList
    {
        public List<Fruits> fruits { get; set; }
    }
}