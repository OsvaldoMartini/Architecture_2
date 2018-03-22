using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPattern.WProject.Data6x.Utils
{
    public class GenericRepository<T>: IGenericRepository<T> where T : BaseBO
    {
        
        
        #region private Properties
        private DbContext Context { get; set; }
        private DbSet<T> DataSet { get; set; }
        #endregion

        #region Constructors
        public GenericRepository(): this(new gpvEntities6x())
        {
        }
        public GenericRepository(DbContext dbContext)
        {
            Context = dbContext;
            DataSet = Context.Set<T>();
        }
        #endregion

        #region Public Method IGenericRepository
        public IQueryable<T> GetQuery()
        {
            return DataSet.AsQueryable();
        }

        public IEnumerable<T> GetAll()
        {
            return DataSet;
        }

        public IEnumerable<T> Where(Func<T, bool> where)
        {
            return DataSet.Where(where);
        }

        public T Single(Func<T, bool> where)
        {
            return DataSet.Single(where);
        }

        public T First()
        {
            return DataSet.First();
        }

        public T First(Func<T, bool> where)
        {
            return DataSet.First(where);
        }

        public void Attach(T entity)
        {
            Validate(entity);
            DataSet.Attach(entity);
        }

        public void Delete(T entity)
        {
            Validate(entity);
            DataSet.Remove(entity);
            SaveChanges();
        }

        public void Add(T entity)
        {
            Validate(entity);
            DataSet.Add(entity);
            SaveChanges();
        }

        public void Update(T entity)
        {
            Validate(entity);
            //Verifica se algum atributo da entidate foi alterado
            DbEntityEntry entityEntry = Context.Entry(entity);
            if (entityEntry.State == EntityState.Detached)
            {
                Context.Set<T>().Attach(entity);
                entityEntry.State = EntityState.Modified;
            }

            SaveChanges();

        }

        public void SaveChanges()
        {
            Context.SaveChanges();
        }

        public void Dispose()
        {
            Context.Dispose();
        }
        #endregion

        #region private Methods
        private void Validate(T entity)
        {
            if (entity is IValidation)
            {
                entity.Validation();
            }
        }
        #endregion

    }

}
