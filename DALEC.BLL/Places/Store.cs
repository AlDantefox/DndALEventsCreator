using DALEC.BLL.Games;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALEC.BLL.Places
{
    public sealed class Store //клуб
    {
        #region Properties
        public String Name { get; set; }
        public Guid ID { get; set; }
        public City City { get; set; }
        public IList<GameEvent> GameEvents { get; set; }
        #endregion

        #region constructor
        private Store(Guid id, string name)
        {
            ID = id;
            Name = name;
        }
        #endregion

        #region Create
        public static Store Create(Guid id, string name, Guid cityID)
        {
            var store = new Store(id, name);
            store.City = City.Get(cityID);
            //
            return store;
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
            foreach (var ge in this.GameEvents)
                ge.Delete();
            //
            throw new NotImplementedException();
        }
        #endregion

        #region Get
        public static Store Get(Guid id)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region GetList
        public static IList<Store> GetList(Guid cityID)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
