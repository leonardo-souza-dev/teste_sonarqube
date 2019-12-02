using System;
using TesteSonarQube.UI;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TesteSonarQube.Teste
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Deve_Retornar_Mensagem_Hello1()
        {
            //arrange
            var horario = new DateTime(2019, 12, 2, 13, 0, 0);

            //act
            var mensagem = Program.ObterMensagem(horario);

            //assert
            Assert.AreEqual("hello", mensagem);
        }

        [TestMethod]
        public void Deve_Retornar_Mensagem_Hello2()
        {
            //arrange
            var horario = new DateTime(2019, 12, 2, 13, 0, 0);

            //act
            var mensagem = Program.ObterMensagem2(horario);

            //assert
            Assert.AreEqual("hello", mensagem);
        }
    }
}