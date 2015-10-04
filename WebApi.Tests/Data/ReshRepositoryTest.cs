using Microsoft.VisualStudio.TestTools.UnitTesting;
using Data;

namespace WebApi.Tests.Data
{
    [TestClass]
    public class ReshRepositoryTest
    {
        [TestMethod]
        public void Test_that_we_get_data_from_RESH()
        {
            ReshRepository reshRepository = new ReshRepository();
            var actual = reshRepository.Get(100320);
            Assert.IsNotNull(actual);
        }
    }
}
