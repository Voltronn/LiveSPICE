﻿using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SyMath;

namespace Circuit
{
    [CategoryAttribute("IO")]
    [DisplayName("Output")]
    public class Output : PassiveTwoTerminal
    {
        public Output() { Name = "O1"; }

        public override void Analyze(ModifiedNodalAnalysis Mna)
        {
            i = Constant.Zero;
        }

        protected override void DrawSymbol(SymbolLayout Sym)
        {
            int w = 10;
            Sym.AddLine(EdgeType.Black, new Coord(-w, 20), new Coord(w, 20));
            Sym.DrawPositive(EdgeType.Black, new Coord(0, 15));
            Sym.AddLine(EdgeType.Black, new Coord(-w, -20), new Coord(w, -20));
            Sym.DrawNegative(EdgeType.Black, new Coord(0, -15));

            Sym.DrawText(Name.ToString(), new Point(0, 0), Alignment.Center, Alignment.Center);
        }
    }
}

