using System;
using System.Collections.Generic;
using System.Text;
using shootersgalley.lemkerdairy.loaders.components.Models;

namespace shootersgalley.lemkerdairy.loaders.loadbook.Models
{
    class recipe
    {
        public caliber Caliber { get; set; }
        public bullet Bullet { get; set; }
        public casing Casing { get; set; }
        public powder Powder { get; set; }
        public primer Primer { get; set; }


    }
}
