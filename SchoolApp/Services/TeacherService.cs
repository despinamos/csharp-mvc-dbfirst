using AutoMapper;
using SchoolApp.Data;
using SchoolApp.DTO;
using SchoolApp.Repositories;

namespace SchoolApp.Services
{
    public class TeacherService : ITeacherService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        private readonly ILogger<TeacherService> _logger;

        public TeacherService(IUnitOfWork unitOfWork, IMapper mapper, ILogger<TeacherService> logger)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _logger = logger;
        }
        public async Task<List<User>> GetAllUsersTeacherAsync()
        {
            List<User> usersTeachers = new();
            try
            {
                usersTeachers = await _unitOfWork.TeacherRepository.GetAllUsersTeachersAsync();
                _logger.LogInformation("{Message}", "All teachers retrieved successfully.");
            } catch (Exception ex)
            {
                _logger.LogError("{Message} {Exception}", ex.Message, ex.StackTrace);
            }
            return usersTeachers;
        }
        public Task<List<User>> GetAllUsersTeachersAsync(int pageNumber, int pageSize)
        {
            throw new NotImplementedException();
        }

        public Task<User?> GetTeacherByUsermameAsync(string username)
        {
            throw new NotImplementedException();
        }

        public Task<int> GetTeacherCountAsync()
        {
            throw new NotImplementedException();
        }

        public Task SignUpUserAsync(TeacherSignUpDTO request)
        {
            throw new NotImplementedException();
        }
    }
}
