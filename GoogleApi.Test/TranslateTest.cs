using System.Linq;
using GoogleApi.Entities.Translate.Translate.Request;
using GoogleApi.Entities.Translate.Translate.Request.Enums;
using NUnit.Framework;

namespace GoogleApi.Test
{
    [TestFixture]
    public class TranslateTest : BaseTest
    {
        [Test]
        public void TranslateCorrectGermanTest()
        {
            var _request = new TranslateRequest { Target = "de", Qs = new[] { "Hello World" }, ApiKey = this._apiKey, Format = Format.TEXT };
            var _result = GoogleTranslate.Translate.Query(_request);

            Assert.AreEqual("Hallo Welt", _result.Data.Translations.First().TranslatedText);
            Assert.AreEqual("en", _result.Data.Translations.First().DetectedSourceLanguage);
        }
        [Test]
        public void TranslateCorrectDanishTest()
        {
            var _request = new TranslateRequest { Target = "da", Qs = new[] { "Hello World" }, ApiKey = this._apiKey, Format = Format.TEXT };
            var _result = GoogleTranslate.Translate.Query(_request);

            Assert.AreEqual("Hej Verden", _result.Data.Translations.First().TranslatedText);
            Assert.AreEqual("en", _result.Data.Translations.First().DetectedSourceLanguage);
        }
    }
}