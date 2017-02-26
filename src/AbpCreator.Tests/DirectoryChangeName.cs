using System;
using System.IO;
using NUnit.Framework;

namespace AbpCreator.Tests
{

    [TestFixture]
    public class DirectoryChangeNameTestCase
    {
        [Test]
        public void Should_ChangeTwo_Layer()
        {
            var sourceP = "Abp";
            var targetP = "Taa";
            var sourcePath = "Abp";
            var targetPath = "Taa";
           
            new DirectoryHelper().ReplaceDirectoryName(sourceP, sourceP, targetP);
            //DirectoryHelper.DirectoryCopy(sourcePath,targetPath,true);
            Assert.IsTrue(Directory.Exists("Taa\\Taa\\Taa"));
        }
    }
}