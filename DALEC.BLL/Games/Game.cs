using DALEC.BLL.Places;
using DALEC.BLL.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALEC.BLL.Games
{
    public sealed class Game // одна игра
    {
        #region Properties
        public String Name { get; set; }
        public Guid ID { get; set; }
        public String CampaignName { get; set; }
        public String Notes { get; set; }
        public int? SessionNumber { get; set; }
        public GameTier Tier { get; set; }
        public GameDay GameDay { get; set; }
        public DNDUser DM { get; set; }
        public Table Table { get; set; }
        public IList<DNDUser> Players { get { return Table == null ? new List<DNDUser>() : Table.Players; }  }
        #endregion

        #region constructor
        private Game(Guid id, string name)
        {
            ID = id;
            Name = name;
        }
        #endregion

        #region Create
        public static Game Create(Guid id, string name, string campaignName, string notes, int? session, GameTier tier, Guid gameDayID, Guid tableID, Guid? dmID)
        {
            var game = new Game(id, name);
            game.CampaignName = campaignName;
            game.Notes = notes;
            game.SessionNumber = session;
            game.Tier = tier;
            game.GameDay = GameDay.Get(gameDayID);
            game.Table = Table.Get(tableID);
            game.DM = dmID.HasValue ? DNDUser.Get(dmID.Value) : null;
            //
            return game;
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
            throw new NotImplementedException();
        }
        #endregion

        #region Get
        public static Game Get(Guid id)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region GetList
        public static IList<Game> GetListByGameDay(Guid gameDayID)
        {
            throw new NotImplementedException();
        }

        public static IList<Game> GetListByDM(Guid dmID)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
