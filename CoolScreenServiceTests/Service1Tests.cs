using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoolScreenService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolScreenService.Tests
{
    [TestClass()]
    public class Service1Tests
    {
        private Service1 service;
        private NoteClass note;

        [TestInitialize]
        public void SetupNote()
        {
            service = new Service1();
            note = new NoteClass(1, "et", "to");
        }
        

//        [TestMethod()]
//        public void CreateOpskriftTest()
//        {
//            Assert.Fail();
//        }
//
//        [TestMethod()]
//        public void GetOpskrifterDBTest()
//        {
//            Assert.Fail();
//        }
//
//        [TestMethod()]
//        public void ReadOpskriftTest()
//        {
//            Assert.Fail();
//        }
//
//        [TestMethod()]
//        public void UpdateOpskriftTest()
//        {
//            Assert.Fail();
//        }
//
//        [TestMethod()]
//        public void DeleteOpskriftTest()
//        {
//            Assert.Fail();
//        }
//
//        [TestMethod()]
//        public void PostTemperaturTest()
//        {
//            Assert.Fail();
//        }
//
//        [TestMethod()]
//        public void ReadTemperaturTest()
//        {
//            Assert.Fail();
//        }
//
//        [TestMethod()]
//        public void GetAvgTemperaturTest()
//        {
//            Assert.Fail();
//        }

        [TestMethod()]
        public void PostNoteTest()
        {
            
            
            Assert.AreEqual(1, service.PostNote(note));
        }

        [TestMethod()]
        public void GetNoteTest1()
        {

            Assert.AreEqual(note.Note, service.GetNote("5").Note);
        }

        [TestMethod()]
        public void GetNoteDBTest()
        {
            Assert.AreEqual(note.Note, service.GetNoteDB()[1].Note);
        }

        [TestMethod()]
        public void DeleteNoteTest()
        {
            Assert.AreEqual(1, service.DeleteNote("7"));
        }

        [TestMethod()]
        public void UpdateNoteTest()
        {
            service.UpdateNote(new NoteClass(2, "one", "two"));
            Assert.AreEqual("two", service.GetNote("2").Note);
        }

//        [TestMethod()]
//        public void GetDataTest()
//        {
//            Assert.Fail();
//        }
//
//        [TestMethod()]
//        public void GetDataUsingDataContractTest()
//        {
//            Assert.Fail();
//        }
    }
}

namespace CoolScreenServiceTests
{
    class Service1Tests
    {
    }
}
