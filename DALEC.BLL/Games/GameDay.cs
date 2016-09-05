using DALEC.BLL.Places;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALEC.BLL.Games
{
    public sealed class GameDay //день для игр
    {
        #region Properties
        public String Name { get; set; }
        public Guid ID { get; set; }
        public GameEvent GameEvent { get; set; }
        public IList<Game> Games { get; set; }
        public IList<Table> Tables { get; set; }
        #endregion

        #region constructor
        private GameDay(Guid id, string name)
        {
            ID = id;
            Name = name;
        }
        #endregion

        #region Create
        public static GameDay Create(Guid id, string name, Guid gameEventID)
        {
            var gd = new GameDay(id, name);
            gd.GameEvent = GameEvent.Get(gameEventID);
            //
            return gd;
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
            foreach (var g in this.Games)
                g.Delete();
            //
            foreach (var t in this.Tables)
                t.Delete();
            //
            throw new NotImplementedException();
        }
        #endregion

        #region Get
        public static GameDay Get(Guid id)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region GetList
        public static IList<GameDay> GetList(Guid gameEventID)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
