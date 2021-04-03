using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Gravatar.Tests
{
    [TestClass]
    public class GravatarExtensionTests
    {
        [TestCategory("Gravatar Tests")]
        [TestMethod("Should validate Gravatar extension")]
        [DataRow(null, 200, false)]
        [DataRow("", 200, false)]
        [DataRow(" ", 200, false)]
        [DataRow("a@a", 200, false)]
        [DataRow("a@marcelo.com", 200, false)]
        [DataRow("marcelopspereira@gmail.com", null, true)]
        [DataRow("marcelopspereira@gmail.com", 200, true)]
        public void ShoulValidateGravatar(string email, int? size, bool status)
        {
            var imageSize = size.HasValue ? size.Value.ToString() : "80";
            var result = "http://www.gravatar.com/avatar/417bb1150463a0ebdd1a20eeb32113ca?s={imageSize}";
            Assert.AreEqual((email.ToGravatar(size ?? 80) == result), status);
        }
    }
}
