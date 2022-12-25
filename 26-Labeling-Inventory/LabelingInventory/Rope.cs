using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabelingInventory {
    public class Rope : InventoryItem {
        public Rope() : base(1, 1.5) {
        
        }

        public override string ToString() => "Rope";
    }
}