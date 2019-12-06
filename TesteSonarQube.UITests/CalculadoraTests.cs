using Microsoft.VisualStudio.TestTools.UnitTesting;
using TesteSonarQube.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteSonarQube.UI.Tests
{
    [TestClass()]
    public class CalculadoraTests
    {
        [TestMethod()]
        public void SomarTest()
        {
            //arrange
            var calculadora = new Calculadora();

            //act
            var resultado = calculadora.Somar(new List<int> { 1, 2 });

            //assert
            Assert.AreEqual(3, resultado);
        }
    }
}