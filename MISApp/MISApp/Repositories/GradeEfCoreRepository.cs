using Microsoft.EntityFrameworkCore.ChangeTracking;
using MISApp.Models;
using MISApp.MyDBContext;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace MISApp.Repositories
{
    public class GradeEfCoreRepository
    {
        public readonly MyDbContext dbContext;
        public GradeEfCoreRepository() => this.dbContext= new MyDbContext();
        public GradeEfCoreRepository(MyDbContext dbContext) => this.dbContext = dbContext; 
        public Grade Create(Grade grade)
        {
            var created = this.dbContext.Add(grade); //why did we add created variable?
            this.dbContext.SaveChanges();
            return grade;
        }
        public void Delete(int id)
        {
            var gradeToDelete = this.dbContext.Grades.FirstOrDefault(c => c.Id == id);

            if (gradeToDelete != null)
            {
                this.dbContext.Remove(gradeToDelete);
                this.dbContext.SaveChanges();
            }
        }

        public IEnumerable<Grade> GetAll()
        {
            return this.dbContext.Grades.ToList();
        }

        public Grade GetById(int id)
        {
            return this.dbContext.Grades.FirstOrDefault(c => c.Id == id, new NullGrade());
        }

        public void Update(int id, Grade grade)
        {
            if (grade.Id == default)
                grade.Id = id;

            this.dbContext.Grades.Update(grade);
            this.dbContext.SaveChanges();
        }
    }
}
