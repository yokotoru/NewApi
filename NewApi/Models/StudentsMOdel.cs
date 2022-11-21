using NewApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewApi.Models
{
    public class StudentsMOdel
    {
         public StudentsMOdel(Student students) 
        {
            Name_id = students.Name_id;
            Name = students.Name;
            Surname = students.Surname;
            Image = students.Image;

        }
        
        public int Name_id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Image { get; set; }
    }
}