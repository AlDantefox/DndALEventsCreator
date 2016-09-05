using DALEC.BLL.Places;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALEC.BLL.Games
{
    public sealed class GameEvent // неделя игры, ролекон
    {
        #region Properties
        public String Name { get; set; }
        public Guid ID { get; set; }
        public Store Store { get; set; }
        public IList<GameDay> GameDays { get; set; }
        #endregion

        #region constructor
        private GameEvent(Guid id, string name)
        {
            ID = id;
            Name = name;
        }
        #endregion

        #region Create
        public static GameEvent Create(Guid id, string name, Guid storeID)
        {
            var ge = new GameEvent(id, name);
            ge.Store = Store.Get(storeID);
            //
            return ge;
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
            foreach (var gd in this.GameDays)
                gd.Delete();
            //
            throw new NotImplementedException();
        }
        #endregion

        #region Get
        public static GameEvent Get(Guid id)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region GetList
        public static IList<GameEvent> GetList(Guid storeID)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
