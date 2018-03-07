﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public struct Field
    {
        public Field (int row, int column)
        {
            Row = row;
            Column = column;
        }

        public readonly int Row;
        public readonly int Column;
    }
}
