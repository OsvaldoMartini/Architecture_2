using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPattern.WProject.Data50.Utils
{
    public interface IGenericRepository<T> : IDisposable where T: BaseBO
    {
        IQueryable<T> GetQuery(); //Retornar Dados de Qualquer Conjunto de Querys   
        IEnumerable<T> GetAll(); //Retornar todos os dados da Entidade   
        IEnumerable<T> Where(Func<T, bool> where); //Selecioonar os dados
        T Single(Func<T, bool> where); //Retornar apenas 1, se a condição ter mais de Um Estoura Exception
        T First();
        T First(Func<T, bool> where); //Retorna o primeiro de uma consulta
        void Attach(T entity); //Coloca o Objeto no cache do Entity Framework
        void Delete(T entity);
        void Add(T entity);
        void Update(T entity);
        void SaveChanges();



    }
}
