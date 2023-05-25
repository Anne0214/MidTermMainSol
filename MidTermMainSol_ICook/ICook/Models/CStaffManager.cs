using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormMain.Models
{
    public class CStaffManager
    {

        List<CStaff> _list = new List<CStaff>();
        

        public CStaffManager()
        {
            loadData();
        }

        private void loadData()
        {
            CStaff x = new CStaff();
            x.id = "001";
            x.name = "Martin";
            x.phone = "0988010473";
            x.email = "martin2023@gmail.com";
            x.address = "Taipei";
            x.password = "55688";
            _list.Add(x);
        }

        public CStaff queryByEmail(string email)
        {
            foreach (CStaff c in _list)
            {
                if (c.email == email)
                    return c;
            }
            return null;
        }
        public List<CStaff> all
        {
            get { return _list; }
        }
    }
}
