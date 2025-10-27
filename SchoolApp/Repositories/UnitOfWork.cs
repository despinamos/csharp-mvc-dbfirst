
using SchoolApp.Data;

namespace SchoolApp.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Mvc6dbContext _context;

        public UnitOfWork(Mvc6dbContext context)
        {
            _context = context;
        }

        public UserRepository UserRepository => new(_context);

        public TeacherRepository TeacherRepository => new(_context);

        public StudentRepository StudentRepository => new(_context);

        public CourseRepository CourseRepository => new(_context);

        public async Task<bool> SaveAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}
