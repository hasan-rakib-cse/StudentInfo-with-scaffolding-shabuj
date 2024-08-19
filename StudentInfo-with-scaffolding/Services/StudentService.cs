using StudentInfo_with_scaffolding.Data;
using StudentInfo_with_scaffolding.Interfaces;
using StudentInfo_with_scaffolding.Models;

namespace StudentInfo_with_scaffolding.Services
{
    public class StudentService:IStudentService
    {
        private readonly AppDbContext context;
        public StudentService(AppDbContext _context)
        {
            context = _context;
        }
        public List<Student> GetStudent()
        {
            var students = new List<Student>();
            students = context.Student.ToList();
            return students; 
        }
    }
}
