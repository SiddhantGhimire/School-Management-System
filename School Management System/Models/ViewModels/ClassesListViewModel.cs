namespace School_Management_System.Models.ViewModels
{
    public class ClassesListViewModel
    {

        public IEnumerable<Classes> Classes { get; }

        public ClassesListViewModel(IEnumerable<Classes> classes)
        {

            Classes = classes;
        }
    }
}
