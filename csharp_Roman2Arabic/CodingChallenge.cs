using Xunit;

namespace Interview
{
    public class CodingChallenge
    {
        [Fact]
        public void Test()
        {
            RomanTranslator test = new RomanTranslator("VI");
            test.ConvertRomanToArabic();
            Assert.Equal(6, test.Value);

            test = new RomanTranslator("LXX");
            test.ConvertRomanToArabic();
            Assert.Equal(70, test.Value);
            
            test = new RomanTranslator("MCC");
            test.ConvertRomanToArabic();
            Assert.Equal(1200, test.Value);

            test = new RomanTranslator("IV");
            test.ConvertRomanToArabic();
            Assert.Equal(4, test.Value);

            test = new RomanTranslator("XC");
            test.ConvertRomanToArabic();
            Assert.Equal(90, test.Value);

            test = new RomanTranslator("CM");
            test.ConvertRomanToArabic();
            Assert.Equal(900, test.Value);

            test = new RomanTranslator("XCV");
            test.ConvertRomanToArabic();
            Assert.Equal(95, test.Value);


            test = new RomanTranslator("XCIX");
            test.ConvertRomanToArabic();
            Assert.Equal(99, test.Value);

            test = new RomanTranslator("XX");
            test.ConvertRomanToArabic();
            Assert.Equal(20, test.Value);

            test = new RomanTranslator("XXX");
            test.ConvertRomanToArabic();
            Assert.Equal(30, test.Value);

        }

    }
}
