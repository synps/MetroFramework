﻿using System.Drawing;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.ComponentModel;
using System.Collections.Generic;

namespace MetroFramework.Native
{
    [DebuggerDisplay("({Top},{Left}) ({Bottom},{Right})")]
    [StructLayout(LayoutKind.Sequential)]
    public struct RECT
    {
        public int Left;
        public int Top;
        public int Right;
        public int Bottom;

        public static RECT Empty;

        public RECT(Rectangle rect)
        {
            Left = rect.Left;
            Top = rect.Top;
            Right = rect.Right;
            Bottom = rect.Bottom;
        }

        public RECT(int left, int top, int right, int bottom)
        {
            Left = left;
            Top = top;
            Right = right;
            Bottom = bottom;
        }

        public Rectangle ToRectangle()
        {
            return new Rectangle(Left, Top, Width, Height);
        }

        public int Height
        {
            get { return (Bottom - Top); }
        }

        public SIZE Size
        {
            get { return new SIZE(Width, Height); }
        }

        public int Width
        {
            get { return (Right - Left); }
        }

        public static implicit operator Rectangle(RECT other)
        {
            return other.ToRectangle();
        }

        public static implicit operator RECT(Rectangle other)
        {
            return new RECT(other);
        }

    }
}