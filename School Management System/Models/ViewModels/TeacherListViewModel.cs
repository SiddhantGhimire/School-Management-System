namespace School_Management_System.Models.ViewModels
{
    public class TeacherListViewModel
    {

        public IEnumerable<Teacher> Teachers { get; }

        public TeacherListViewModel(IEnumerable<Teacher> teacher)
        {

            Teachers = teacher;
        }
    }
}
