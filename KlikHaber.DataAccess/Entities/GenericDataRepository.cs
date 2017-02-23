using KlikHaber.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace KlikHaber.DataAccess
{
    public class GenericDataRepository : IGenericDataRepository
    {

        [BsonId]
        public ObjectId Id { get; set; }

        /*
        public void Add(params T[] entities)
        {
            if (entities == null || entities.Count() == 0)
                return;
            
            var doc = new Document();
            foreach (var entity in entities)
            {
                Table table = Table.LoadTable(Database.Client_, entity.GetType().Name);
                table.PutItem(ConvertObjectToDocument(entity));
            }
        }

        public List<T> Get(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, params Expression<Func<T, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public T GetById(object id)
        {
            throw new NotImplementedException();
        }

        public T GetFirstOrDefault(Expression<Func<T, bool>> filter = null, params Expression<Func<T, object>>[] includes)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> Query(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null)
        {
            throw new NotImplementedException();
        }

        public void Remove(params T[] entities)
        {
            throw new NotImplementedException();
        }

        public void Update(params T[] entities)
        {
            throw new NotImplementedException();
        }

        public Document ConvertObjectToDocument(T entity)
        {
            Document doc = new Document();
            Type type = entity.GetType();

            IList<PropertyInfo> props = new List<PropertyInfo>(type.GetProperties());

            foreach (PropertyInfo prop in props)
            {
                object propValue = prop.GetValue(entity, null);
                switch (propValue.GetType().Name.ToString())
                {
                    case "Int32":
                        doc[prop.Name] = Convert.ToInt32(propValue);
                        break;
                    case "Int64":
                        doc[prop.Name] = Convert.ToInt64(propValue);
                        break;
                    default:
                        doc[prop.Name] = propValue.ToString();
                        break;
                }
            }
            return doc;
        }*/
    }

}
