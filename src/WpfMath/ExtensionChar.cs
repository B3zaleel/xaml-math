using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfMath
{
    /// <summary>
    /// Extension character that contains character information for each of its parts.
    /// </summary>
    internal class ExtensionChar
    {
        public ExtensionChar(CharInfo top, CharInfo middle, CharInfo bottom, CharInfo repeat, CharInfo left = null, CharInfo right = null)
        {
            this.Top = top;
            this.Middle = middle;
            this.Repeat = repeat;
            this.Bottom = bottom;
            this.Left = left;
            this.Right = right;
        }

        public CharInfo Top
        {
            get;
            private set;
        }

        public CharInfo Middle
        {
            get;
            private set;
        }

        public CharInfo Bottom
        {
            get;
            private set;
        }

        public CharInfo Repeat
        {
            get;
            private set;
        }
        
        public CharInfo Left { get; private set; }

        public CharInfo Right { get; private set; }
        
    }
}
