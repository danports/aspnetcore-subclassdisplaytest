using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SubclassDisplayTest.Models
{
    public class Widget
    {
        public int A { get; set; } = 3;
    }

    public class Subwidget : Widget
    {
        public int B { get; set; } = 6;
    }

    public class DetailsModel
    {
        public Widget Widget { get; set; }
    }
}
