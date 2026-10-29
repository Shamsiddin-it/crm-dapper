using Domain.Models;

namespace Domain.Interfaces;

public interface IStudentRepository
{
    Task<bool> AddStudentAsync(Student student);
    bool UpdateStudent(Student student);
    bool DeleteStudent(int studentId);
    Student GetStudent(int studentId);
    List<Student> GetStudents();
}
