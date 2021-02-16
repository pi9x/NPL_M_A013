using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Linq;
using AMSLibrary.Entities;

namespace AMSLibrary.DataAccess
{
    abstract class GenericAccess<T> : IGenericAccess<T> where T : IHasId
    {
        protected internal string filePath;

        public void Create(T entity, bool orderById = false)
        {
            List<T> entities = Get(out int currentId);

            currentId++;
            entity.SetId(entity.GetPrefix() + currentId.ToString("00000"));
            
            entities.Add(entity);

            // Option to order entities by Id, default value = false
            if (orderById)
                entities = entities.OrderBy(e => e.GetId()).ToList();

            string json = JsonSerializer.Serialize(entities, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        public void Delete(string id)
        {
            List<T> entities = Get(out _);
            int deleteCount = entities.RemoveAll(e => e.GetId() == id);
            if (deleteCount > 0)
            {
                string json = JsonSerializer.Serialize(entities, new JsonSerializerOptions { WriteIndented = true });
                File.WriteAllText(filePath, json);
            }
            else
                throw new Exception($"{typeof(T).Name} {id} does not exists.");
        }

        public List<T> Get(out int currentId)
        {
            string json = File.ReadAllText(filePath);

            if (string.IsNullOrWhiteSpace(json))
            {
                currentId = 0;
                return new List<T>();
            }
                
            List<T> entities = JsonSerializer.Deserialize<List<T>>(json);

            if (entities == null)
            {
                currentId = 0;
                return new List<T>();
            }

            currentId = int.Parse(entities.Last().GetId()[^5..]);
            return entities;
        }

        public T GetById(string id)
        {
            List<T> entities = Get(out _);
            T entity = entities.Find(e => e.GetId().Equals(id));

            if (entity == null)
                throw new Exception($"Getting {typeof(T).Name} failed: {id} not found.");

            return entity;
        }

        public void Update(T entity)
        {
            List<T> entities = Get(out _);
            entities[entities.FindIndex(e => e.GetId() == entity.GetId())] = entity;
            string json = JsonSerializer.Serialize(entities, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }
    }
}
