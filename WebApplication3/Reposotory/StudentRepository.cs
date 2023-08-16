using WebApplication3.Data;
using WebApplication3.Interfaces;
using WebApplication3.Models;

namespace WebApplication3.Reposotory
{
    public class StudentRepository : IStudentRepository
    {
        private DataContext _context;
        public StudentRepository(DataContext context)
        {
            _context = context;
        }

        public bool CreateStudent( Student student)
        {
            _context.Add(student); 
            return Save();
        }

        public bool DeleteStudent(Student student)
        {
            _context.Remove(student);
            return Save();
        }

        public Student GetStudent(int id)
        {
            return _context.Students.Where(p => p.Id == id).FirstOrDefault();
        }

        public ICollection<Student> GetStudents()
        {
            return _context.Students.OrderBy(x => x.Id).ToList();
        }

        public bool HasStudent(int id)
        {
            return _context.Students.Any(s => s.Id == id);
        }

        public bool Save()
        {
            var saved = _context.SaveChanges();
            return saved > 0 ? true : false;
        }

        public bool UpdateStudent(Student student)
        {
            _context.Update(student);
            return Save();
        }
        public bool DeleteStudent(int id)
        {
            var student = _context.Students.Where(s => s.Id == id).FirstOrDefault();
            _context.Remove(student);
            return Save();
        }
    }
}
