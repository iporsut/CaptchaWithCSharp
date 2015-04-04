using NUnit.Framework;
using System;
using CaptchaLibrary;

namespace NUnitCaptchaTest
{
	[TestFixture ()]
	public class Test
	{
		[Test ()]
		public void Operator_WhenInputIs2118_ShouldBePlus() {
			Captcha captcha = new Captcha(2, 1, 1, 8);
			String oper = captcha.Operator();
			Assert.AreEqual("+", oper);
		}

		[Test ()]
		public void Operator_WhenInputIs2128_ShouldBeMultiply() {
			Captcha captcha = new Captcha(2, 1, 2, 8);
			String oper = captcha.Operator();
			Assert.AreEqual("*", oper);
		}

		[Test ()]
		public void Operator_WhenInputIs2138_ShouldBeMultiply() {
			Captcha captcha = new Captcha(2, 1, 3, 8);
			String oper = captcha.Operator();
			Assert.AreEqual("-", oper);
		}

		[Test ()]
		public void RightOperand_WhenInputIs2118_ShouldBe8() {
			Captcha captcha = new Captcha(2, 1, 1, 8);
			String operand = captcha.RightOperand();
			Assert.AreEqual("8", operand);
		}

		[Test ()]
		public void RightOperand_WhenInputIs1118_ShouldBeEight() {
			Captcha captcha = new Captcha(1, 1, 1, 8);
			String operand = captcha.RightOperand();
			Assert.AreEqual("Eight", operand);
		}

		[Test ()]
		public void RightOperand_WhenInputIs1119_ShouldBeNine() {
			Captcha captcha = new Captcha(1, 1, 1, 9);
			String operand = captcha.RightOperand();
			Assert.AreEqual("Nine", operand);
		}

		[Test ()]
		public void LeftOperand_WhenInputIs2199_ShouldBeOne() {
			Captcha captcha = new Captcha(2, 1, 9, 9);
			String operand = captcha.LeftOperand();
			Assert.AreEqual("One", operand);
		}

		[Test ()]
		public void LeftOperand_WhenInputIs2911_ShouldBeOne() {
			Captcha captcha = new Captcha(2, 9, 1, 1);
			String operand = captcha.LeftOperand();
			Assert.AreEqual("Nine", operand);
		}

		[Test ()]
		public void LeftOperand_WhenInputIs1199_ShouldBe1() {
			Captcha captcha = new Captcha(1, 1, 9, 9);
			String operand = captcha.LeftOperand();
			Assert.AreEqual("1", operand);
		}

		[Test ()]
		public void LeftOperand_WhenInputIs1299_ShouldBe2() {
			Captcha captcha = new Captcha(1, 2, 9, 9);
			String operand = captcha.LeftOperand();
			Assert.AreEqual("2", operand);
		}

		[Test ()]
		public void LeftOperand_WhenInputIs1999_ShouldBe9() {
			Captcha captcha = new Captcha(1, 9, 1, 1);
			String operand = captcha.LeftOperand();
			Assert.AreEqual("9", operand);
		}
	}
}

