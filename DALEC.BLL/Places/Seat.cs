using DALEC.BLL.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALEC.BLL.Places
{
    public sealed class Seat // место за столом
    {
        #region Properties
        public int Number { get; set; }
        public Guid ID { get; set; }
        public DNDUser Player { get; set; }
        public Table Table { get; set; }
        #endregion

        #region constructor
        private Seat(Guid id, int number)
        {
            ID = id;
            Number = number;
        }
        #endregion

        #region Create
        public static Seat Create(Guid id, int number, Guid tableID, Guid? playerID)
        {
            var seat = new Seat(id, number);
            seat.Table = Table.Get(tableID);
            seat.Player = playerID.HasValue ? DNDUser.Get(playerID.Value) : null;
            //
            return seat;
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
        public static Seat Get(Guid id)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region GetList
        public static IList<Seat> GetList(Guid tableID)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
