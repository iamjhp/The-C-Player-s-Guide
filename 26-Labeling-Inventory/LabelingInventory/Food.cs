using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabelingInventory {
    public class Food : InventoryItem {
        public Food() : base(1, 0.5) {

        }

        public override string ToString() => "Food";
    }
}
