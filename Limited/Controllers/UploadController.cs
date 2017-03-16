using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations;
using Limited.Models;

namespace Limited.Controllers
{
    public class UploadController : Controller
    {
        // GET: Upload
        public ActionResult Index()
        {
            return View("Create");
        }

      

        TestDBEntities db = new TestDBEntities();
        public ActionResult Create(Contact newContact)
        {
            try
            {
                Contact objContact = new Contact();
                objContact.Address = newContact.Address;
                objContact.Contact_Number = newContact.Contact_Number;
                objContact.Name = newContact.Name;
                db.Contacts.Add(objContact);
                db.SaveChanges();

            }
            catch(Exception ex)
            {

            }
            return View();
        }
    }

}