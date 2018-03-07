using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model;
namespace Tests
{
    [TestClass]
    public class FieldTest
    {
        [TestMethod]
        public void Field_RowAndColumnCorrespondToValuesProvidedByConstructor()
        {
            Field f = new Field(3,4);
            Assert.AreEqual(3,f.Row);
            Assert.AreEqual(4, f.Column);
        }
    }
}
