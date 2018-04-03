using labamobilki2.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace labamobilki2.ViewModel
{
    public class VMMain
    {
        private Item item;

        public string Name { get => item.name; }
        public string Shortdescr { get => item.shortdescr; }
        public string LongDescr { get => item.longdescr; }
        public string Image { get => item.image1; }

        public VMMain(Item elem)
        {
            this.item = elem;
        }

        public VMDescription GenerateDescription()
        {
            return new VMDescription(this.item);
        }
    }
}
