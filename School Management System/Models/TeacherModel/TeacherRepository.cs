﻿using Microsoft.EntityFrameworkCore;

namespace School_Management_System.Models.TeacherModel
{
    public class TeacherRepository : ITeacherRepository
    {

        private readonly SchoolManagementDbContext _schoolManagementDbContext;

        public TeacherRepository(SchoolManagementDbContext schoolManagementDbContext)
        {

            _schoolManagementDbContext = schoolManagementDbContext;
        }

        public IEnumerable<Teacher> AllTeacher
        {
            get
            {
                return _schoolManagementDbContext.Teachers;
            }
        }


        public void AddTeacher(Teacher teacher)
        {

            _schoolManagementDbContext.Teachers.Add(teacher);
            _schoolManagementDbContext.SaveChanges();
        }


        public Teacher? GetTeacherById(int teacherId)
        {

            return _schoolManagementDbContext.Teachers.FirstOrDefault(p => p.TeacherId == teacherId);
        }

        public void UpdateTeacher(Teacher teacher)
        {

            var existingTeacher = _schoolManagementDbContext.Teachers.FirstOrDefault(p => p.TeacherId == teacher.TeacherId);
            if (existingTeacher == null)
            {
                throw new ArgumentException("Teacher not found");
            }


            existingTeacher.Name = teacher.Name;
            existingTeacher.Picture = teacher.Picture;
            existingTeacher.PhoneNumber = teacher.PhoneNumber;
            existingTeacher.Subject = teacher.Subject;

            _schoolManagementDbContext.Entry(existingTeacher).State = EntityState.Modified;
            _schoolManagementDbContext.SaveChanges();
        }

        public void DeleteTeacher(int id)
        {

            var teacher = _schoolManagementDbContext.Teachers.Find(id);

            if (teacher == null)
            {
                throw new ArgumentException("teacher not found");
            }


            _schoolManagementDbContext.Teachers.Remove(teacher);
            _schoolManagementDbContext.SaveChanges();

        }
    }
}
