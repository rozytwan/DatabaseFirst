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
        TestDBEntities db = new TestDBEntities();
        Contact objCont = new Contact();

        // GET: Upload
        public ActionResult Index()
        {
            objCont.contactList = db.Contacts.ToList();
            return View("Index", objCont.contactList);
        }

        public ActionResult Insert()
        {
            return View();
        }

        public ActionResult Save(Contact objContact)
        {
            objCont.Name = objContact.Name;
            objCont.Address = objContact.Address;
            objCont.Contact_Number = objContact.Contact_Number;
            db.Contacts.Add(objCont);
            db.SaveChanges();
            objCont.contactList = db.Contacts.ToList();
            return View("Index", objCont.contactList);
            
        }

        public ActionResult Edit(Contact objContact,int id)
        {
            Contact cont = db.Contacts.Find(id);
         
           
            return View(cont);
        }

        public ActionResult Update(Contact objContact,int id)
        {
            Contact cont = db.Contacts.Find(id);
            cont.Name = objContact.Name;
            cont.Address = objContact.Address;
            cont.Contact_Number = objContact.Contact_Number;
            db.Entry(cont);
            db.SaveChanges();
            objCont.contactList = db.Contacts.ToList();
            return View("Index", objCont.contactList);
        }



        public ActionResult Delete()
        {
            return View();
        }
    }
}