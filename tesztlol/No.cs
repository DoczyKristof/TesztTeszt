using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tesztlol;
using NUnit.Framework;

namespace tesztlol
{
    [TestFixture]
    class No
    {
        [TestCase]
        public void NewPresConsPos()
        {
            Eloadas eloadas = new Eloadas(420, 69);
        }
        [TestCase]
        public void NewPresConsNeg()
        {
            Assert.Throws<ArgumentException>(() => { Eloadas eloadas = new Eloadas(-420, -69); });
        }
        [TestCase]
        public void NewPresConsNull()
        {
            Assert.Throws<ArgumentException>(() => { Eloadas eloadas = new Eloadas(0, 0); });
        }
        [TestCase]
        public void NewBookPos()
        {
            Eloadas eloadas = new Eloadas(420, 69);
            eloadas.book();
        }
        [TestCase]
        public void BookOnePlaceNotFull()
        {
            Eloadas eloadas = new Eloadas(420, 69);
            eloadas.book();
            Assert.AreEqual(false, eloadas.Full());
        }
        [TestCase]
        public void BookAllPlaceFull()
        {
            Eloadas eloadas = new Eloadas(420, 69);
            for (int i = 0; i < 28980; i++)
            {
                eloadas.book();
            }
            Assert.AreEqual(true, eloadas.Full());
        }
        [TestCase]
        public void CheckIfBooked()
        {
            Eloadas eloadas = new Eloadas(420, 69);
            for (int i = 0; i < 28980; i++)
            {
                eloadas.book();
            }
            Assert.AreEqual(true, eloadas.Booked(6, 9));
        }
        [TestCase]
        public void CheckIfBookedNeg()
        {
            Eloadas eloadas = new Eloadas(420, 69);
            for (int i = 0; i < 350; i++)
            {
                eloadas.book();
            }
            Assert.AreEqual(false, eloadas.Booked(19, 19));
        }
        [TestCase]
        public void NoFreeSpace()
        {
            Eloadas eloadas = new Eloadas(420, 69);
            for (int i = 0; i < 28980; i++)
            {
                eloadas.book();
            }
            Assert.AreEqual(0, eloadas.freeSpace());
        }
        [TestCase]
        public void FreeSpacePos()
        {
            Eloadas eloadas = new Eloadas(420, 69);
            for (int i = 0; i < 350; i++)
            {
                eloadas.book();
            }
            Assert.Greater(eloadas.freeSpace(), 0);
        }
    }
}