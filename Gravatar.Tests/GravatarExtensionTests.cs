using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Gravatar.Tests
{
    [TestClass]
    public class GravatarExtensionTests
    {
        [TestCategory("Gravatar Tests")]
        [TestMethod("Should validate Gravatar extension")]
        //http://www.gravatar.com/avatar/417bb1150463a0ebdd1a20eeb32113ca
        [DataRow(null, false)]
        [DataRow("", false)]
        [DataRow(" ", false)]
        [DataRow("a@a", false)]
        [DataRow("a@marcelo.com", false)]
        [DataRow("marcelopspereira@gmail.com", true)]
        public void ShoulValidateGravatar(string email, bool status)
        {
            var result = "http://www.gravatar.com/avatar/417bb1150463a0ebdd1a20eeb32113ca";
             Assert.AreEqual((email.ToGravatar() == result), status);
        }
    }
}
