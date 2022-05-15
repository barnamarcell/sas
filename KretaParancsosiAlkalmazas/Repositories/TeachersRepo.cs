﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Kreta.Models;

namespace Kreta.Repositories
{
    public partial class TeachersRepo
    {
        private List<Teacher> teachers;

        public List<Teacher> Teachers
        {
            get
            {
                return teachers;
            }
        }

        public int NumberOfTeacher
        {
            get
            {
                return teachers.Count;
            }
        }

        public TeachersRepo()
        {
            teachers = new List<Teacher>();
            MakeTestData();
        }

        public List<Teacher> GetAllTeachers()
        {
            return new List<Teacher>(teachers);
        }


        public void MakeTestData()
        {
            teachers.Add(new Teacher(1, "Számoló", "Szonja", "123456", true, EmploymentValue.LECTURER));
            teachers.Add(new Teacher(2, "Buktató", "Béla", "123456", false, EmploymentValue.INDENTUREDLABOURER));
            teachers.Add(new Teacher(3, "Aritmetika", "Antal", "123456", false, EmploymentValue.DONEONCOMMISSION));
            teachers.Add(new Teacher(4, "Arany", "András", "123456", false, EmploymentValue.DONEONCOMMISSION));
            teachers.Add(new Teacher(5, "Sportoló", "Jenő", "123456", false, EmploymentValue.DONEONCOMMISSION));
            teachers.Add(new Teacher(6, "Visszanéző", "Viola", "123456", false, EmploymentValue.DONEONCOMMISSION));
        }
    }
}
