﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabelingInventory {
    public class Bow : InventoryItem {
        public Bow() : base(1, 4) { }

        public override string ToString() => "Bow";
    }
}
