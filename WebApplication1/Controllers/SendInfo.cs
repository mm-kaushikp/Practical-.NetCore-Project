using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class SendInfo : Controller
    {
        public ActionResult Index()
        {
            List<SelectListItem> sendList = new List<SelectListItem>();
            sendList.Add(new SelectListItem()
            {
                Text = "Monitor",
                Value = "Monitor"
            });
            sendList.Add(new SelectListItem()
            {
                Text = "CPU",
                Value = "CPU"
            });
            sendList.Add(new SelectListItem()
            {
                Text = "Keyboard",
                Value = "Keyboard"
            });
            sendList.Add(new SelectListItem()
            {
                Text = "Mouse",
                Value = "Mouse"
            });
            sendList.Add(new SelectListItem()
            {
                Text = "GamePad",
                Value = "GamePad"
            });
            ViewBag.dropDownValue = sendList;
            return View();
        }

        [HttpPost]
        public ActionResult Index(string dropDownValue, string checkBoxValue)
        {
            List<SelectListItem> sendList = new List<SelectListItem>();
            sendList.Add(new SelectListItem()
            {
                Text = "Monitor",
                Value = "Monitor"
            });
            sendList.Add(new SelectListItem()
            {
                Text = "CPU",
                Value = "CPU"
            });
            sendList.Add(new SelectListItem()
            {
                Text = "Keyboard",
                Value = "Keyboard"
            });
            sendList.Add(new SelectListItem()
            {
                Text = "Mouse",
                Value = "Mouse"
            });
            sendList.Add(new SelectListItem()
            {
                Text = "GamePad",
                Value = "GamePad"
            });
            ViewBag.dropDownValue = sendList;
            return RedirectToAction("TransferData", new sendData() { dropdownValue = "Item : " + dropDownValue, CheckValue = "Show Full Record : " + checkBoxValue });
        }

        public ActionResult TransferData(sendData sendData)
        {
            return View("DisplayData", sendData);
        }
    }
}
