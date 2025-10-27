using SchoolApp.Data;
using SchoolApp.DTO;

namespace SchoolApp.Services
{
    public interface ITeacherService
    {
        Task SignUpUserAsync(TeacherSignUpDTO request);
        Task<List<User>> GetAllUsersTeacherAsync();
        Task<List<User>> GetAllUsersTeachersAsync(int pageNumber, int pageSize);
        Task<int> GetTeacherCountAsync();
        Task<User?> GetTeacherByUsermameAsync(string username);
    }
}
