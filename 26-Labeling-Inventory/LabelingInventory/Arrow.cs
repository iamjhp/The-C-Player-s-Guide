﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabelingInventory {
    public class Arrow : InventoryItem {
        public Arrow() : base(0.1, 0.05) { }

        public override string ToString() => "Arrow";
    }
}
