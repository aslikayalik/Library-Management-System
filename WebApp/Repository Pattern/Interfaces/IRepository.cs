﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Repository_Pattern.Interfaces
{
   public interface IRepository<T> where T:BaseEntity 
    { 
        List<T> GetAll();  
        List<T> GetActives(); 
        T GetById(int id); 
        void Add(T item); 
        void Update(T item);
        void Delete(int id);
        void SpecialDelete(int id); 
        List<T> GetByFilter(Expression<Func<T,bool>> exp); 
        T Default(Expression<Func<T, bool>> exp);
        int Count(); 
        bool Any(Expression<Func<T,bool>> exp);
        List<T> SelectActivesByLimit(int count); 
    }
}
