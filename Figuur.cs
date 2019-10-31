using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SchetsEditor
{
    class Figuur
    {
        private int xMin;
        private int yMin;
        private int xMax;
        private int yMax;
        private int kleur;
        private StartpuntTool soort;


        public Figuur(int xm, int xM, int ym, int yM, int kl, StartpuntTool soortFiguur)
        {
            xMin = xm;
            xMax = xM;
            yMin = ym;
            yMax = yM;
            kleur = kl;
            soort = soortFiguur;
        }

        public bool isRaak(int x, int y)
        {
            if(x < xMax && x > xMin && y < yMax && y > yMin)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
