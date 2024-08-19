using StudentInfo_with_scaffolding.Models;

namespace StudentInfo_with_scaffolding.Interfaces
{
    public interface IStudentService
    {
        public List<Student> GetStudent();
    }
}
