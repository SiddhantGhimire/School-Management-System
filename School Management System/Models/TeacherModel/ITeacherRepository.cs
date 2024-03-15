namespace School_Management_System.Models.TeacherModel
{
    public interface ITeacherRepository
    {


        IEnumerable<Teacher> AllTeacher { get; }
        void AddTeacher(Teacher teacher);
        Teacher? GetTeacherById(int teacherId);
        void UpdateTeacher(Teacher teacher);
        void DeleteTeacher(int teacher);
    }
}
