﻿using School_Management_System.Models;

namespace schoolmanagementsystem.Models.ViewModels
{
    public class StudentListViewModel
    {
        public IEnumerable<Student> Students { get; }

        public StudentListViewModel(IEnumerable<Student> students)
        {

            Students = students;
        }
    }
}