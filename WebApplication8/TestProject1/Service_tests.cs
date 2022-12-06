using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication8;
using WebApplication8.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.AspNetCore.Mvc;
using Xunit;




namespace TestProject1
{
    public class Service_tests
    {

        private readonly personcontr _controller;
        private readonly Iperservice _perservice;

        public Service_tests()
        {
            _perservice = new Service_testFAKE();
            
        }


        [Fact]       
        public void checkcount()
        {
            int count  = 4;

            _controller.Deleteuserbyid(count);

            Assert.Equals(2,_perservice.GettAll().Count());

        }
    }
}
