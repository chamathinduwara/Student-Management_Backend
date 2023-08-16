using WebApplication3.Models;

namespace WebApplication3.Interfaces
{
    public interface IStudentRepository
    {
        ICollection<Student> GetStudents();
        Student GetStudent(int id);
        bool HasStudent(int id);
        bool CreateStudent(Student student);
        bool UpdateStudent(Student student);
        bool DeleteStudent(int id);
        bool Save();

    }
}
