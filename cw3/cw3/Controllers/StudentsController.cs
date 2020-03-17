using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace cw3.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class StudentsController : ControllerBase
    {

        //zad3
        [HttpGet]
        public string getStudents()
        {
            return "Jan Żaczek";
        }

        //zad4
        [HttpGet("{id}")]
        public IActionResult getStudents(int id)
        {
            if (id == 1)
            {
                return Ok("Kowalski");
            }
            else if(id == 2)
            {
                return Ok("Nowak");
            }
            return NotFound("Nie znaleziono studenta");
        }
        //       [HttpGet("getStudents")]    // jezeli dam tutaj w nawiasie stringa to jest kolejny po slashu czesc w URL
        // httpget zeby wyciagnac dane o studencie
        //[HttpGet("{id}")] - jezeli damy zadanie daj studenta z id 2 w url to "pod spodem" w tym kodzie wyswietli nam studenta z id =2
        //lecz wtedy musimy dac query paramater int id - takie samo

        //[HttpGet("{id}")]
        //public string getStudents(int id)
        //{
        //    if (id == 1)
        //    {
        //        return "Kowalski";
        //    }
        //    else if (id == 2)
        //    {
        //        return "Malewski";
        //    }

        //    return ("Nie znaleziono studenta");
        //}

        //[HttpGet]
        //public string getStudents(string orderby)
        //{
        //    return $"sortowanie={orderby}";
        //}

    }
}