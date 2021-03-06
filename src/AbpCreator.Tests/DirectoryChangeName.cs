﻿using System;
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
        [Test]
        public void Should_Match()
        {
            StringReplacePattern pattern =new StringReplacePattern("Himall","gxB2b");

            string g = @"'himall_xxx'\r\n'HImalL.GGG  himall'";
            string replace = null;
            pattern.MatchAndReplace(g, out replace);

            Console.WriteLine(replace);
        }
    }
}