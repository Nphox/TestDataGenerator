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

        [Test]
        public void GenerateUser_RegistrationDatePeriod()
        {
            UserEntity entity = _generator.GenerateUser();
            DateTime registrationDate = entity.RegistrationDate;

            Assert.That(registrationDate, Is.InRange(new DateTime(2010, 1, 1), new DateTime(2016, 2, 29)));
        }

        [Test]
        public void GenerateUser_GetValueLine()
        {
            UserEntity user = new UserEntity()
            {
                Name = "Петр",
                Surename = "Петов",
                Patronymic = "Петрович",
                Email = "petr@gmail.com",
                Login = "petr",
                Password = "12345",
                RegistrationDate = new DateTime(2016, 1, 1)
            };
            const string EXPECTED_RESULT = @"VALUES('Петр', 'Петов', 'Петрович', 'petr@gmail.com', 'petr', '12345', '20160101')";

            string result = _generator.GetValueLine(user);

            Assert.That(result, Is.EqualTo(EXPECTED_RESULT));
        }
    }
}
