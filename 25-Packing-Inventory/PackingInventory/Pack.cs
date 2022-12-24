using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackingInventory {
    public class Pack {
        private InventoryItem[] items;

        public Pack(int maxCount, double maxWeight, double maxVolume) {
            MaxCount = maxCount;
            MaxWeight = maxWeight;
            MaxVolume = maxVolume;
            this.items = new InventoryItem[maxCount];
        }

        public int MaxCount { get; }
        public double MaxWeight { get; }
        public double MaxVolume { get; }
        public int CurrCount { get; private set; }
        public double CurrWeight { get; private set; }
        public double CurrVolume { get; private set; }

        public bool Add(InventoryItem item) {
            if (CurrCount >= MaxCount) return false;
            if (CurrWeight + item.Weight > MaxWeight) return false;
            if (CurrVolume + item.Volume > MaxVolume) return false;

            this.items[CurrCount] = item;
            CurrWeight += item.Weight;
            CurrVolume += item.Volume;
            CurrCount++;

            return true;
        }

    }
}
