using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrowFactories {
    public class Arrow {
        public ArrowHead ArrowHead { get; }
        public Fletching Fletching { get; }
        public float Length { get; }

        public Arrow(ArrowHead arrowHead, Fletching fletching, float length) {
            ArrowHead = arrowHead;
            Fletching = fletching;
            Length = length;
        }

        public float Cost { 
            get {
                float arrowHeadCost = ArrowHead switch {
                    ArrowHead.Steel => 10,
                    ArrowHead.Wood => 3,
                    ArrowHead.Obsidian => 5
                };

                float fletchingCost = Fletching switch {
                    Fletching.Plastic => 10,
                    Fletching.GooseFeathers => 3,
                    Fletching.TurkeyFeathers => 5
                };

                float shaftCost = 0.05f * Length;

                return arrowHeadCost + fletchingCost + shaftCost;
            } 
        }

        public static Arrow CreateEliteArrow() => new Arrow(ArrowHead.Steel, Fletching.Plastic, 95);
        public static Arrow CreateBeginnerArrow() => new Arrow(ArrowHead.Wood, Fletching.GooseFeathers, 75);
        public static Arrow CreateMarksmanArrow() => new Arrow(ArrowHead.Steel, Fletching.GooseFeathers, 65);
    }
}
