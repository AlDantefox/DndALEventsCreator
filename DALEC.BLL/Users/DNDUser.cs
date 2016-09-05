using DALEC.BLL.Games;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALEC.BLL.Users
{
    public class DNDUser
    {
        #region Properties
        public String Name { get; set; }
        public Guid ID { get; set; }
        public String Nickname { get; set; }
        public String Notes { get; set; }
        public bool Removed { get; set; }
        public IList<Game> GamesAsDM { get; }
        public IList<Game> GamesAsPlayer { get; }
        #endregion

        #region constructor
        private DNDUser(Guid id, string name)
        {
            ID = id;
            Name = name;
        }
        #endregion

        #region Create
        public static DNDUser Create(Guid id, string name, string nickname, string notes, bool removed = false)
        {
            var user = new DNDUser(id, name);
            user.Nickname = nickname;
            user.Notes = notes;
            user.Removed = removed;
            //
            return user;
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
            //не удалять, только помечать удаленными и не показывать для регистрации
            throw new NotImplementedException();
        }
        #endregion

        #region Get
        public static DNDUser Get(Guid id)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region GetList
        public static IList<DNDUser> GetList(bool withRemoved)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
