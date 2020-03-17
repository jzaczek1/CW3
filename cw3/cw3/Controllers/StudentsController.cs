using cw3.DAL;
using cw3.Models;
using Microsoft.AspNetCore.Mvc;
using System;

namespace cw3.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class StudentsController : ControllerBase
    {

        //zad8====================================================================
        private readonly IDbService _dbservice;
        public StudentsController(IDbService dbService) => _dbservice = dbService;

        [HttpGet]
        public IActionResult GetStudents(string orderBy)
        {
            return Ok(_dbservice.GetStudents());
        }
        //zad3=================================================================
        //[HttpGet]
        //public string getStudents()
        //{
        //    return "Jan Żaczek";
        //}

        ////zad4================================================================
        [HttpGet("{id}")]
        public IActionResult getStudents(int id)
        {
            if (id == 1)
            {
                return Ok("Kowalski");
            }
            else if (id == 2)
            {
                return Ok("Nowak");
            }
            return NotFound("Nie znaleziono studenta");
        }

        //zad5===================================================================
        //[HttpGet]
        //public string getStudents(string orderBy)
        //{
        //    return $"To jest string z orderBy, sortowanie = {orderBy}";
        //}

        //zad6===================================================================
        [HttpPost]
        public IActionResult createStudent(Student student)
        {
            student.IndexNumber = $"s{new Random().Next(1, 20000)}";
            return Ok(student);
        }
        //zad7===================================================================
        [HttpPut("{id}")]
        public IActionResult changeStudent(int id)
        {
            return Ok("Aktualizacja dokończona");
        }

        [HttpDelete("{id}")]
        public IActionResult deleteStudent(int id)
        {
            return Ok("Usuwanie zakończone");
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