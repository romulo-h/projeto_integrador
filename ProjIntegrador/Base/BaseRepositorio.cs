using Microsoft.EntityFrameworkCore;
using ProjIntegrador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Base
{
    public class BaseRepositorio<T> where T : BaseModel
    {
        private readonly Contexto ctx;

        public BaseRepositorio()
        {
            ctx = new Contexto();
        }

        class SwapVisitor : ExpressionVisitor
        {
            private readonly Expression from, to;
            public SwapVisitor(Expression from, Expression to)
            {
                this.from = from;
                this.to = to;
            }
            public override Expression Visit(Expression node)
            {
                return node == from ? to : base.Visit(node);
            }
        }

        virtual public void Delete(T obj)
        {
            if (obj != null)
            {
                obj.DtDeleted = DateTime.Now;
                obj.IsActive = false;
                try
                {
                    Contexto _ctx = new Contexto();
                    _ctx.Entry(obj).State = EntityState.Modified;
                    _ctx.SaveChanges();
                }
                catch (Exception e)
                {
                    obj.IsActive = true;
                    //Utils.WriterExeption(new List<string>() { e.Message, e.ToString() }, "Base Repositório - Delete");
                }
            }
        }

        virtual public void Delete(Func<T, bool> predicate)
        {
            T obj = this.Find(predicate);
            if (obj != null)
            {
                obj.DtDeleted = DateTime.Now;
                obj.IsActive = false;
                this.Update(obj);
            }
        }

        virtual public bool Delete(int Id)
        {
            T obj = this.FindById(Id);

            if (obj?.IsActive == false)
                return !obj.IsActive;

            if (obj != null)
            {
                this.Delete(obj);
                return !obj.IsActive;
            }
            return false;
        }

        virtual public T FindActive(Func<T, bool> predicate)
        {
            return this.Find(m => predicate(m) && m.IsActive == true);
        }

        virtual public T Find(Func<T, bool> predicate)
        {
            return ctx.Set<T>().AsNoTracking().FirstOrDefault(predicate);
        }

        virtual public T FindById(int Id, bool Filter = true)
        {
            return Filter ? ctx.Set<T>().AsNoTracking().FirstOrDefault(m => m.Id == Id && m.IsActive == true) : ctx.Set<T>().AsNoTracking().FirstOrDefault(m => m.Id == Id);
        }

        virtual public IEnumerable<T> Get(Func<T, bool> predicate)
        {
            return ctx.Set<T>().Where(predicate).ToList();
        }

        virtual public IEnumerable<T> GetAll(Func<T, bool> predicate)
        {
            Func<T, bool> BasePredicate = s => s.IsActive == true;
            Func<T, bool> _predicate = s => predicate(s) && BasePredicate(s);

            return ctx.Set<T>().Where(_predicate);
        }

        virtual public IEnumerable<T> GetAll()
        {
            return ctx.Set<T>().Where(x => x.IsActive == true);
        }

        virtual public bool Save(T obj)
        {
            obj.IsActive = true;
            obj.DtCreate = DateTime.Now;
            try
            {
                ctx.Set<T>().Add(obj);
                ctx.SaveChanges();
            }
            catch (Exception e)
            {
                //Utils.WriterExeption(new List<string>() { e.Message, e.ToString() }, "Base Repositório - Save");
            }

            return obj.Id > 0;
        }

        virtual public void SaveList(IEnumerable<T> obj)
        {
            obj = obj.Select(c =>
            {
                c.DtCreate = DateTime.Now;
                c.IsActive = true;
                return c;
            });
            try
            {
                ctx.Set<T>().AddRange(obj);
                ctx.SaveChanges();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        virtual public void Update(T obj)
        {
            try
            {
                var objAlter = new Contexto().Set<T>().FirstOrDefault(m => m.Id == obj.Id);
                if (objAlter != null)
                {
                    obj.DtCreate = objAlter.DtCreate;
                    obj.DtDeleted = objAlter.DtDeleted;
                    obj.IsActive = objAlter.IsActive;
                    obj.DtAlter = DateTime.Now;
                    objAlter = null;

                    Contexto _ctx = new Contexto();
                    _ctx.Entry(obj).State = EntityState.Modified;
                    _ctx.SaveChanges(); //save it                    
                }
            }
            catch (Exception e)
            {
                obj.Id = 0;
                //Utils.WriterExeption(new List<string>() { e.Message, e.ToString() }, "Base Repositório - Update");
            }
        }

        //Update do Active sem dtDeleted
        virtual public void Update(T obj, bool Ativo)
        {
            try
            {
                var objAlter = new Contexto().Set<T>().FirstOrDefault(m => m.Id == obj.Id);
                if (objAlter != null)
                {
                    obj.DtCreate = objAlter.DtCreate;
                    obj.DtDeleted = objAlter.DtDeleted;
                    obj.IsActive = Ativo;
                    obj.DtAlter = DateTime.Now;
                    objAlter = null;

                    ctx.Entry(obj).State = EntityState.Modified;
                    ctx.SaveChanges(); //save it                    
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }


        virtual public void Dispose()
        {
            ctx.Dispose();
        }

        #region Application

        virtual public void SaveApp(T obj, string UserCreate, DateTime DtCreate)
        {
            obj.IsActive = true;
            obj.DtCreate = DtCreate;

            try
            {
                ctx.Set<T>().Add(obj);
                ctx.SaveChanges();
            }
            catch (Exception e)
            {
                //Utils.WriterExeption(new List<string>() { e.Message, e.ToString() }, "Base Repositório - SaveApp");
            }
        }

        virtual public void UpdateApp(T obj, string UserCreate)
        {
            try
            {
                var objAlter = new Contexto().Set<T>().FirstOrDefault(m => m.Id == obj.Id);
                if (objAlter != null)
                {
                    obj.DtCreate = objAlter.DtCreate;
                    obj.DtDeleted = objAlter.DtDeleted;
                    obj.IsActive = objAlter.IsActive;
                    obj.DtAlter = DateTime.Now;
                    objAlter = null;

                    Contexto _ctx = new Contexto();
                    _ctx.Entry(obj).State = EntityState.Modified;
                    _ctx.SaveChanges();
                }
            }
            catch (Exception e)
            {
                obj.Id = 0;
                //Utils.WriterExeption(new List<string>() { e.Message, e.ToString() }, "Base Repositório - UpdateApp");
            }
        }
        #endregion
    }
}
