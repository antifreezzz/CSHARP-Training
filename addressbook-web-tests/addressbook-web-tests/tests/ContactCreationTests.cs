using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactCreationTests : TestBase
    {

        [Test]
        public void ContactCreationTest()
        {
            ContactData contact = new ContactData("Имя", "Фамилия");
            contact.Firstname = "Name";
            contact.Middlename = "MiddleName";
            contact.Lastname = "Lastname";
            contact.Nickname = "Nickname";
            contact.Title = "Title";
            contact.Company = "Company";
            contact.Address = "Address";
            contact.Home = "Home";
            contact.Mobile = "712893213";
            contact.Work = "Work";
            contact.Fax = "23213123";
            contact.Email = "Email1";
            contact.Email2 = "Email2";
            contact.Email3 = "Email3";
            contact.Homepage = "Homepage";
            contact.Bday = "11";
            contact.Bmonth = "August";
            contact.Byear = "1568";
            contact.Aday = "12";
            contact.Amonth = "November";
            contact.Ayear = "1233";
            contact.Address2 = "Address2";
            contact.Phone2 = "Phone2";
            contact.Notes = "Notes";
            


            app.Navigator.GoToHomePage();
            app.Auth.Login(new AccountData("admin", "secret"));
            app.contacts.InitContactCreation();
            app.contacts.FillContactForm(contact);
            app.contacts.SubmitContactCreation();
            app.Navigator.GoToHomePage();
        }


    }
}
