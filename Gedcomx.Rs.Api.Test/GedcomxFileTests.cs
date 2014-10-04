﻿using Gedcomx.File;
using KellermanSoftware.CompareNetObjects;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gedcomx.Rs.Api.Test
{
    [TestFixture]
    public class GedcomxFileTests
    {
        [Test]
        public void TestReadingJarFile()
        {
            var file = TestBacking.WriteBytesToDisk(Resources.TestJar);
            var fi = new FileInfo(file);
            using (GedcomxFile test = new GedcomxFile(fi))
            {
                Assert.IsNotNull(test);
                Assert.IsNotNull(test.Attributes);
                Assert.AreEqual(2, test.Attributes.Count);
                Assert.IsNotNull(test.GetAttribute("Manifest-Version"));
                Assert.IsNotNull(test.Entries);
                Assert.Greater(test.Entries.Count(), 0);

                foreach (var entry in test.Entries)
                {
                    using (var stream = test.GetResourceStream(entry))
                    {
                        Assert.IsNotNull(stream);
                        Assert.IsTrue(stream.CanRead);
                    }
                }
            }
        }

        [Test]
        public void TestXmlSerialization()
        {
            var serializer = new DefaultXMLSerialization();
            var gxExpected = TestBacking.GetGedcomxObject();

            byte[] bytes;

            using (var ms = new MemoryStream())
            {
                serializer.Serialize(gxExpected, ms);
                bytes = ms.ToArray();
            }

            var gxActual = (Gx.Gedcomx)serializer.Deserialize(new MemoryStream(bytes));

            var comparer = new CompareLogic();
            var differences = comparer.Compare(gxExpected, gxActual);

            Assert.AreEqual(0, differences.Differences.Count);
        }

        [Test]
        public void TestManifestParsing()
        {
            var file = TestBacking.WriteBytesToDisk(Resources.TestJar);
            var fi = new FileInfo(file);
            var results = ManifestAttributesParser.Parse(System.IO.Compression.ZipFile.OpenRead(file));

            Assert.IsNotNull(results);
            Assert.AreEqual(6, results.Count);
            Assert.IsNull(results[results.Keys.Where(x => x.FullName == "META-INF/").Single()]);
            Assert.AreEqual(2, results[results.Keys.Where(x => x.FullName == "META-INF/MANIFEST.MF").Single()].Count);
            Assert.AreEqual(3, results[results.Keys.Where(x => x.FullName == "Test1.txt").Single()].Count);
            Assert.AreEqual(3, results[results.Keys.Where(x => x.FullName == "Test4.txt").Single()].Count);
        }
    }
}