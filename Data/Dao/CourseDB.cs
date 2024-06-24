using School.Data.Context;
using School.Data.Exceptions;
using School.Data.Interfaces;
using School.Data.Models.CourseModel;

namespace School.Data.Dao
{
    public class CourseDB : ICourseDb
    {
        private readonly SchoolContext _context;

        public CourseDB(SchoolContext context) 
        {
            this._context = context;
        }
        public void Remove(CourseRemoveModel removeModel)
        {
            var courseToRemove = this._context.Courses.Find(removeModel.Id);
            if (removeModel == null)
            {
                throw new BaseDbException("Ese Curso no se encuentra registrado");
            }
            courseToRemove!.Deleted = removeModel.Deleted;
            courseToRemove.DeleteDate = removeModel.DeleteDate;
            courseToRemove.UserDelete = removeModel.UserDelete;

            _context.Courses.Remove(courseToRemove);
            _context.SaveChanges();

        }

        public List<CourseModel> GetAll()
        {
            return this._context.Courses.Select(c => new CourseModel()
            {
                Title = c.Title,
                Credits = c.Credits,
                DepartmentID = c.DepartmentID,

            }).ToList();
        }

        public CourseModel GetModelById(int id)
        {
            var course= _context.Courses.Find(id);

            ///Missing exception

            CourseModel courseModel = new CourseModel()
            {
                Title = course?.Title,
                Credits = course!.Credits,
                DepartmentID = course.DepartmentID,

            };
            return courseModel;
        }

        public void Save(CourseAddModel addModel)
        {
            throw new NotImplementedException();
        }

        public void Update(CourseUpdateModel updateModel)
        {
            throw new NotImplementedException();
        }

    }
}
