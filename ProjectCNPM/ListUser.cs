using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCNPM
{
    public class ListUser
    {
        private static ListUser instance;
        private List<User> listAccountUser;

        public List<User> ListAccountUser { get => listAccountUser; set => listAccountUser = value; }

        public static ListUser Instance
        {
            get
            {
                if (instance == null)
                    instance = new ListUser();
                return instance;
            }

            set => instance = value;
        }

        private ListUser()
        {
            listAccountUser = new List<User>();
            listAccountUser.Add(new User("thanhhieu", "12345", true));
            listAccountUser.Add(new User("nhom12", "12345", false));
        }
    }
}
