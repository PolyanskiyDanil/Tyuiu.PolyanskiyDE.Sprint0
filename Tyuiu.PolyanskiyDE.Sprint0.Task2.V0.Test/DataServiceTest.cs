﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PolyanskiyDE.Sprint0.Task2.V0.Lib;

namespace Tyuiu.PolyanskiyDE.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Данил";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет..., Данил", res);
        }
    }
}
