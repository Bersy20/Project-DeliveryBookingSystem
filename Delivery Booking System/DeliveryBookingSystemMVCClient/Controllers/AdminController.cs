﻿using DeliveryBookingSystemMVCClient.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryBookingSystemMVCClient.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult AdminPage()
        {
            return View();
        }
        [HttpGet]
        public ActionResult LoginAdmin()
        {
            Admin admin = new Admin();
            try
            {
                admin.AdminEmail = TempData.Peek("AdminEmail").ToString();
                return View(admin);
            }
            catch (Exception e)
            {
                return View(admin);
            }
        }
        [HttpPost]
        public async Task<ActionResult> LoginAdmin(Admin admin)
        {
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(admin), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PostAsync("http://localhost:27527/api/Admin/LoginAdmin", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    var obj = JsonConvert.DeserializeObject<Admin>(apiResponse);
                    TempData["AdminEmail"] = obj.AdminEmail;
                    if (obj.AdminEmail == null)
                    {
                        return RedirectToAction("AdminLoginErrorPage");
                    }
                    else
                    {
                        if (obj.AdminEmail != null)
                        {
                            return RedirectToAction("AdminPage");
                        }
                        else
                        {
                            return RedirectToAction("ErrorPage", "Home");
                        }
                    }
                }
            }
        }
        public ActionResult AdminLoginErrorPage()
        {
            return View();
        }
    }
}
