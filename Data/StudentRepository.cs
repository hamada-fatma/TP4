using System.Linq.Expressions;
using TP4.Controllers;
using TP4.Models;

namespace TP4.Data
{


    public interface IStudentRepository<TEntity> where TEntity : class
    {
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> predicate);
        bool Add(TEntity entity);
        // bool AddRange(IEnumerable<TEntity> entities);
        bool Remove(TEntity entity);
        //bool RemoveRange(IEnumerable<TEntity> entities);
        IEnumerable<String> GetCourses();

    }
    public class StudentRepository : IStudentRepository<Student>
    {
        private readonly UniversityContext universityContext;
        public StudentRepository(UniversityContext universityContext)
        //: base(universityContext)
        {
            this.universityContext = universityContext;
        }

        public bool Add(Student entity)
        {
            //throw new NotImplementedException();
            try
            {
                universityContext.Set<Student>().Add(entity);
                //universityContext.SaveChanges();

                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public IEnumerable<Student> Find(Expression<Func<Student, bool>> predicate)
        {
            // throw new NotImplementedException();

            return universityContext.Set<Student>().Where(predicate);


        }

        public Student Get(int id)
        {
            // throw new NotImplementedException();
            return universityContext.Set<Student>().Find(id);
        }

        public IEnumerable<Student> GetAll()
        {
            // throw new NotImplementedException();
            return universityContext.Set<Student>().ToList();
        }

        public bool Remove(Student entity)
        {

            try
            {
                universityContext.Set<Student>().Remove(entity);
                //universityContext.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public IEnumerable<String> GetCourses()
        {
            //return _universityContext.Student.Select(s => s.Course).Distinct().ToList();
            return universityContext.Student.Select(s => s.course).Distinct().ToList();

        }
    }
}