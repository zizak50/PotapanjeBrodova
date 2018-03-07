﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Field_RowAndColumnCorresponToValuesProvidedByConstructor()
        {
            Field f = new Model.Field(3, 4);
            Assert.AreEqual(3, f.Row);
            Assert.AreEqual(4, f.Column); 
        }
    }
}
