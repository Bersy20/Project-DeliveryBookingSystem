﻿using DeliveryBookingSystemMVCClient.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryBookingSystemMVCClient.Controllers
{
    public class CustomerController : Controller
    {
        public ActionResult CustomerPage()
        {
            return View();
        }
        [HttpGet]
        public ActionResult RegisterCustomer()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> RegisterCustomer(Customer customer)
        {
            using (var httpClient = new HttpClient())
            {
                customer.City = customer.City.ToUpper();
                StringContent content = new StringContent(JsonConvert.SerializeObject(customer), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PostAsync("http://localhost:27527/api/Customer/PostCustomer", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    var obj = JsonConvert.DeserializeObject<Customer>(apiResponse);
                    if(obj != null)
                    {
                        TempData["CustomerEmail"] = obj.CustomerEmail;
                        TempData["Success"] = "You have sucessfully Registered...";
                        return RedirectToAction("LoginCustomer");
                    }
                    TempData["RegFailCust"] = "User Name already Exists...";
                    return RedirectToAction("RegisterCustomer");
                }
            }            
        }
        [HttpGet]
        public ActionResult LoginCustomer()
        {
            Customer customer = new Customer();
            try
            {
                customer.CustomerEmail = TempData.Peek("CustomerEmail").ToString();
                return View(customer);
            }
            catch (Exception e)
            {
                return View(customer);
            }
        }
        [HttpPost]
        public async Task<ActionResult> LoginCustomer(Customer customer)
        {
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(customer), Encoding.UTF8, "application/json");
                using (var response = await httpClient.PostAsync("http://localhost:27527/api/Customer/LoginCustomer", content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    var obj = JsonConvert.DeserializeObject<Customer>(apiResponse);
                    TempData["CustomerEmail"] = obj.CustomerEmail;
                    TempData["CustomerId"] = obj.CustomerId;
                    TempData["CustomerName"] = obj.CustomerName;
                    if (obj.CustomerEmail == null)
                    {
                        return RedirectToAction("CustomerLoginErrorPage");
                    }
                    else
                    {
                        if (obj.CustomerEmail != null)
                        {
                            return RedirectToAction("CustomerPage");
                        }
                        else
                        {
                            return RedirectToAction("ErrorPage", "Home");
                        }
                    }
                }
            }
        }
        public async Task<ActionResult> ListOfCustomers()
        {
            string Baseurl = "http://localhost:27527/";
            var CustomerInfo = new List<Customer>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.GetAsync("api/Customer/AllCustomers");
                if (Res.IsSuccessStatusCode)
                {
                    var CustomerResponse = Res.Content.ReadAsStringAsync().Result;

                    CustomerInfo = JsonConvert.DeserializeObject<List<Customer>>(CustomerResponse);

                }
                return View(CustomerInfo);
            }
        }
        public async Task<ActionResult> EditCustomerDetails(int id)
        {
            TempData["CustomerId"] = id;
            Customer customer = new Customer();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:27527/api/Customer/CustomerById?id=" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    customer = JsonConvert.DeserializeObject<Customer>(apiResponse);
                }
            }
            return View(customer);
        }
        [HttpPost]
        public async Task<ActionResult> EditCustomerDetails(Customer customer)
        {
            int CustomerId = Convert.ToInt32(TempData["CustomerId"]);
            customer.City = customer.City.ToUpper();
            using (var httpClient = new HttpClient())
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(customer), Encoding.UTF8, "application/json");

                using (var response = await httpClient.PutAsync("http://localhost:27527/api/Customer/" + CustomerId, content))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    var obj = JsonConvert.DeserializeObject<Customer>(apiResponse);
                }
            }
            return RedirectToAction("ListOfCustomers");
        }
        public async Task<ActionResult> DeleteCustomerDetails(int id)
        {
            TempData["CustomerId"] = id;
            Customer customer = new Customer();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("http://localhost:27527/api/Customer/CustomerById?id=" + id))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    customer = JsonConvert.DeserializeObject<Customer>(apiResponse);
                }
            }
            return View(customer);
        }
        [HttpPost]
        public async Task<ActionResult> DeleteCustomerDetails(Customer customer)
        {
            int CustomerId = Convert.ToInt32(TempData["CustomerId"]);
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.DeleteAsync("http://localhost:27527/api/Customer/" + CustomerId))
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                }
            }
            return RedirectToAction("listOfCustomers");
        }
        public async Task<ActionResult> ListOfVerifiedCustomers()
        {
            string Baseurl = "http://localhost:27527/";
            var CustomerInfo = new List<Customer>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.GetAsync("api/Customer/WithVerifiedStatus");
                if (Res.IsSuccessStatusCode)
                {
                    var CustomerResponse = Res.Content.ReadAsStringAsync().Result;
                    CustomerInfo = JsonConvert.DeserializeObject<List<Customer>>(CustomerResponse);
                }
                return View(CustomerInfo);
            }
        }
        public async Task<ActionResult> ListOfNotVerifiedCustomers()
        {
            string Baseurl = "http://localhost:27527/";
            var CustomerInfo = new List<Customer>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(Baseurl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.GetAsync("api/Customer/WithoutVerifiedStatus");
                if (Res.IsSuccessStatusCode)
                {
                    var CustomerResponse = Res.Content.ReadAsStringAsync().Result;
                    CustomerInfo = JsonConvert.DeserializeObject<List<Customer>>(CustomerResponse);
                }
                return View(CustomerInfo);
            }
        }
        public ActionResult CustomerLoginErrorPage()
        {
            return View();
        }
        public async Task<ActionResult> UpdatePassword()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> UpdatePassword(IFormCollection frm, string action)
        {
            if (action == "Submit")
            {

                int id = Convert.ToInt32(frm["txtCustId"]);
                TempData["id"] = id;
                string name = frm["txtUserName"];
                TempData["CustomerEmail"] = name;
                using (var httpClient = new HttpClient())
                {
                    using (var response = await httpClient.GetAsync("http://localhost:27527/api/Customer/CustomerById?id=" + id))
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        var obj = JsonConvert.DeserializeObject<Customer>(apiResponse);
                        if (obj.CustomerId == id && obj.CustomerEmail == name)
                        {
                            return RedirectToAction("UpdatePassword2");
                        }
                        else
                        {
                            TempData["error"] = "Invalid User Name or ID...";
                        }
                    }
                }
            }
            return RedirectToAction("LoginCustomer");
        }
        public async Task<ActionResult> UpdatePassword2()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> UpdatePassword2(IFormCollection frm, string action)
        {
            if (action == "Submit")
            {
                Customer customer = new Customer();
                int id =Convert.ToInt32(TempData.Peek("id"));
                string password = frm["txtPass"];
                string confirmPassword = frm["txtConPass"];
                if(password== confirmPassword)
                {                  
                    using (var httpClient = new HttpClient())
                    {
                        StringContent content = new StringContent(password, Encoding.UTF8, "application/json");

                        using (var response = await httpClient.PutAsync("http://localhost:27527/api/Customer/UpdatePassword?id=" + id+"&password="+password,content))
                        {
                            string apiResponse = await response.Content.ReadAsStringAsync();
                        }
                    }
                    TempData["passC"] = "Password sucessfully updated...Login with Your new password";
                    return RedirectToAction("LoginCustomer");
                }
                TempData["passErr"] = "Check the Password there is a Mismatch...";
                return RedirectToAction("UpdatePassword2");
            }
            return RedirectToAction("UpdatePassword");
        }
    }
}
