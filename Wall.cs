using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPreb
{
    internal abstract class Wall : Element
    {
        public static char WallSymbol = '▓';

        public abstract void DrawWall(); 
    }
}
