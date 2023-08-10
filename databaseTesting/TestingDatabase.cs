using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using NUnit.Framework;

namespace databaseTesting
{
    internal class TestingDatabase  // inheritance
    {
        [Test]
        [STAThread]
        public void TestInsert()
        {
            //AAA

            //Arrange

            string name = "tst3";
            int age = 30;
            string email ="tst3@gmail.com";

            //Act
            databaseOperations.addData(name, age, email);
            string[] dataRetrive = databaseOperations.selectLastData(email);
            MessageBox.Show(dataRetrive[0]);
            MessageBox.Show(dataRetrive[1]);

            //Assert
            Assert.AreEqual(name, dataRetrive[0]);
            Assert.AreEqual(age, int.Parse(dataRetrive[1].ToString()));
        }
    }
}
