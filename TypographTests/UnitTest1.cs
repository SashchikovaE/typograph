using typograph;
namespace TypographTests
{
    [TestClass]
    public class UnitTest1
    {
        Typographh t = new Typographh();
        [TestMethod]
        public void WhitespaceTest()
        {
            string a = "привет  лиза";
            string b = "привет лиза";
            string c = t.ruleWhitespace(a);
            Assert.AreEqual(b, c);
        }
        [TestMethod]
        public void PlusMinusTest()
        {
            string a = "1+-0,5";
            string b = "1±0,5";
            string c = t.rulePlusMinus(a);
            Assert.AreEqual(b, c);
        }
        [TestMethod]
        public void SharpTest()
        {
            string a = "ирина сишарповна";
            string b = "ирина си#овна";
            string c = t.ruleSharp(a);
            Assert.AreEqual(b, c);
        }
        [TestMethod]
        public void QuotationTest()
        {
            string a = "'ещкере'";
            string b = "«ещкере»";
            string c = t.ruleQuotationMarks(a);
            Assert.AreEqual(b, c);
        }
        [TestMethod]
        public void DushnilaTest()
        {
            string a = "ясно.";
            string b = "ясно фу, душнила";
            string c = t.ruleDushnila(a);
            Assert.AreEqual(b, c);
        }
        [TestMethod]
        public void DimensionsTest()
        {
            string a = "20x30";
            string b = "20×30";
            string c = t.ruleDimensions(a);
            Assert.AreEqual(b, c);
        }
        [TestMethod]
        public void SobakaTest()
        {
            string a = "собака сутулая";
            string b = "@ сутулая";
            string c = t.ruleSobaka(a);
            Assert.AreEqual(b, c);
        }
    }
}