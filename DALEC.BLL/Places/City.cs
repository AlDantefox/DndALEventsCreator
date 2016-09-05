using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALEC.BLL.Places
{
    public sealed class City //город
    {
        #region Properties
        public String Name { get; set; }
        public Guid ID { get; set; }
        public IList<Store> Stores { get; set; }
        #endregion

        #region constructor
        private City(Guid id, string name) {
            ID = id;
            Name = name;
        }
        #endregion

        #region Create
        public static City Create(Guid id, string name)
        {
            return new City(id, name);
        }
        #endregion

        #region Insert/Update
        public void Save()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region Delete
        public void Delete()
        {
            foreach (var s in this.Stores)
                s.Delete();
            //
            throw new NotImplementedException();
        }
        #endregion

        #region Get
        public static City Get(Guid id)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region GetList
        public static IList<City> GetList()
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}
