using Microsoft.EntityFrameworkCore.ChangeTracking;
using MISApp.Models;
using MISApp.MyDBContext;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace MISApp.Repositories
{
    public class ClassEfCoreRepository
    {
        public readonly MyDbContext dbContext;
        public ClassEfCoreRepository() => this.dbContext= new MyDbContext();
        public ClassEfCoreRepository(MyDbContext dbContext) => this.dbContext = dbContext; 
        public Class Create(Class classEntity)
        {
            var created = this.dbContext.Add(classEntity); //why did we add created variable?
            this.dbContext.SaveChanges();
            return classEntity;
        }
        public void Delete(int id)
        {
            var classToDelete = this.dbContext.Classes.FirstOrDefault(c => c.Id == id);

            if (classToDelete != null)
            {
                this.dbContext.Remove(classToDelete);
                this.dbContext.SaveChanges();
            }
        }

        public IEnumerable<Class> GetAll()
        {
            return this.dbContext.Classes.ToList();
        }

        public Class GetById(int id)
        {
            return this.dbContext.Classes.FirstOrDefault(c => c.Id == id, new NullClass());
        }

        public void Update(int id, Class classEntity)
        {
            if (classEntity.Id == default)
                classEntity.Id = id;

            this.dbContext.Classes.Update(classEntity);
            this.dbContext.SaveChanges();
        }
    }
}
