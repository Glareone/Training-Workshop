using System.IO;
using System.Xml.Serialization;

namespace Training.Workshop.Data.FileSystem
{
    public abstract class RepositoryBase
    {
        /// <summary>
        /// Saves entity
        /// </summary>
        /// <param name="entity"></param>
        protected void Save(object entity)
        {
            using (var fileStream = File.OpenWrite(".\\workshop.database"))
            {
                new XmlSerializer(entity.GetType()).Serialize(fileStream, entity);
            }
        }
    }
}