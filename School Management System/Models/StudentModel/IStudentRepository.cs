using School_Management_System.Models;

using System.Collections.Generic;

namespace schoolmanagementsystem.Models.StudentModel
{
    public interface IStudentRepository
    {
        IEnumerable<Student> AllStudent { get; }
        void AddStudent(Student student);
        Student? GetStudentById(int studentId);
        void UpdateStudent(Student student);
        void DeleteStudent(int student);


    }
}