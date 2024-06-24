using School.Data.Models.CourseModel;
using Shop.Data.Entities;

namespace School.Data.Interfaces
{
    public interface ICourseDb: IBaseDB<CourseModel,CourseAddModel,CourseUpdateModel, CourseRemoveModel>
    {

    }
}
