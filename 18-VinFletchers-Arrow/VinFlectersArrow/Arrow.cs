using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinFlectersArrow {
    public class Arrow {
        private ArrowHead arrowHead;
        private Fletching fletching;
        private float length;

        public Arrow(ArrowHead arrowHead, Fletching fletching, float length) {
            this.arrowHead = arrowHead;
            this.fletching = fletching;
            this.length = length;
        }

        public float GetCost() {
            float arrowHeadCost = arrowHead switch {
                ArrowHead.Steel => 10,
                ArrowHead.Wood => 3,
                ArrowHead.Obsidian => 5
            };

            float fletchingCost = fletching switch {
                Fletching.Plastic => 10,
                Fletching.GooseFeathers => 3,
                Fletching.TurkeyFeathers => 5
            };

            float shaftCost = 0.05f * length;

            return arrowHeadCost + fletchingCost + shaftCost;
        }
    }
}
