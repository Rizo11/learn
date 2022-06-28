using System;
using System.Collections;
using System.Collections.Generic;

namespace Waste
{
    public class Dumpster
    {
        public IList Items { get; } = new ArrayList();

        public void Dispose(params object[] dispose) 
        {
            foreach(var item in dispose) 
            {
                Items.Add(item);
            }
        }

        public void Process() {
            foreach(var item in Items) {
                Incinerator.Burn(item);
            }
        }
    }

}
