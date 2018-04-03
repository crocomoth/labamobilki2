using labamobilki2.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace labamobilki2.ViewModel
{
    public class VMDescription
    {
        private Item item;

        public VMDescription(Item item)
        {
            this.item = item;
        }

        public string Name { get => item.name; }
        public string Shordescr { get => item.shortdescr; }
        public string LongDescr { get => item.longdescr; }
        public string Link { get => item.link; }
        public string Image2 { get => item.image2; }
    }
}
