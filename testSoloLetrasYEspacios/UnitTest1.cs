using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace testSoloLetrasYEspacios
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void CadenaCorrecta()
		{
			bool resultado = ChallengeDirmod.Program.SoloLetrasYEspacios("soloLetras");
			Assert.IsTrue(resultado);
		}

		[TestMethod]
		public void CadenaIncorrecta()
		{
			bool resultado = ChallengeDirmod.Program.SoloLetrasYEspacios("l3tr451num3r0s");
			Assert.IsFalse(resultado);
		}

		[TestMethod]
		public void DescifrarLetraNoConsecutiva()
		{
			string resultado = ChallengeDirmod.Program.DescifrarCaracter("", 'a', 's');
			Assert.AreEqual("7777", resultado);
		}

		[TestMethod]
		public void DescifrarLetraConsecutiva()
		{
			string resultado = ChallengeDirmod.Program.DescifrarCaracter("", 'h', 'h');
			Assert.AreEqual(" 44", resultado);
		}

		[TestMethod]
		public void DescifrarErrorNumero()
		{
			string resultado = ChallengeDirmod.Program.DescifrarCaracter("", 'm', '5');
			Assert.AreEqual("", resultado);
		}
	}
}
