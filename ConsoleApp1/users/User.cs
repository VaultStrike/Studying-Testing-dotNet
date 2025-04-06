using StudyingTesting.poker_hands.game_area;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyingTesting.users
{
    public class User
    {
        private string username;
        private List<User_Role> roles;
        private List<Table> tables = new List<Table>();

        public List<User_Role> Roles { get => roles; set => roles = value; }
        public string Username { get => username; set => username = value; }
        public List<Table> Tables { get => tables; }

        //הדרך הראשונה
        //public void AddTable()
        //{
        //    tables.Add(new Table());
        //}
        public void AddTable()
        {
            if (roles != null && (roles.Contains(User_Role.ADMIN) || roles.Contains(User_Role.MANAGER)))
            {
                tables.Add(new Table());
            }
        }
    }
}