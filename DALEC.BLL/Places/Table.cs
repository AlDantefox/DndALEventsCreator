using DALEC.BLL.Games;
using DALEC.BLL.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALEC.BLL.Places
{
    public sealed class Table //игровой стол
    {
        #region Properties
        public int Number { get; set; }
        public Guid ID { get; set; }
        public string Note { get; set; }
        public int SeatsCount { get; set; }
        public Game Game { get; set; }
        public GameDay GameDay { get; set; }
        public IList<Seat> Seats { get; set; }
        public DNDUser DM { get { return Game == null ? null : Game.DM; } }
        public IList<DNDUser> Players { get { return Seats.Where(s => s != null && s.Player != null).Select(s => s.Player).ToList(); } }
        #endregion

        #region constructor
        private Table(Guid id, int number)
        {
            ID = id;
            Number = number;
        }
        #endregion

        #region Create
        public static Table Create(Guid id, int number, string note, int seatsCount, Guid gameDayID, Guid? gameID)
        {
            var table = new Table(id, number);
            table.Note = note;
            table.SeatsCount = seatsCount;
            table.GameDay = GameDay.Get(gameDayID);
            table.Game = gameID.HasValue ? Game.Get(gameID.Value) : null; 
            //
            return table;
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
            foreach (var s in this.Seats)
                s.Delete();
            //
            throw new NotImplementedException();
        }
        #endregion

        #region Get
        public static Table Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public static Table GetByGame(Guid gameID)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region GetList
        public static IList<Table> GetList(Guid gameDayID)
        {
            throw new NotImplementedException();
        }
        #endregion

    }
}
