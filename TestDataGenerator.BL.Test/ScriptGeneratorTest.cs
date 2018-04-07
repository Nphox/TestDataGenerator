using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using TestDataGenerator.Data;


namespace TestDataGenerator.BL.Test
{
    [TestFixture]
    public class ScriptGeneratorTest
    {
        private IScriptGenerator _generator;

        [SetUp]
        public void Init()
        {
            _generator = null;
        }

        [Test]
        public void GenerateUser_NameRequired()
        {
            UserEntity entity = _generator.GenerateUser();
            string name = entity.Name;

            Assert.That(name, Is.Not.Empty);
        }

        [Test]
        public void GenerateUser_SurenameRequired()
        {
            UserEntity entity = _generator.GenerateUser();
            string surename = entity.Surename;

            Assert.That(surename, Is.Not.Empty);
        }

        [Test]
        public void GenerateUser_LoginRequired()
        {
            UserEntity entity = _generator.GenerateUser();
            string login = entity.Login;

            Assert.That(login, Is.Not.Empty);
        }

        [Test]
        public void GenerateUser_PasswordRequired()
        {
            UserEntity entity = _generator.GenerateUser();
            string password = entity.Password;

            Assert.That(password, Is.Not.Empty);
        }

        [Test]
        public void GenerateUser_EmailRequired()
        {
            UserEntity entity = _generator.GenerateUser();
            string email = entity.Email;

            Assert.That(email, Is.Not.Empty);
        }
    }
}
