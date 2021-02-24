using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    public interface IEntityRepository<T> where T:class, IEntity, new()
    {
       
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        
    }
}

// fitre=null verince hepsini istiyor. filter görevi kapalı yani.
// IEntityRepository<T> where T:class, IEntity bunu sınırlandırdık,T, sadece class olabilir yani referans tip olup değer tipi olamaz.
// IEntity- T IEntity  olabilir yada IEntity İmplemente eden bir nesne oalbilir(customer, category, product).
//new(), newlenebilir olmalı, IEntity abstract yani interfaece olduğu için newlenemez, olduğu için onuda devre dışı bırakır.
