using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class BaseDb
    {
        public string[] Db;
    }

    class Usegs:BaseDb
    {
            
        public Usegs()
        {
            string[] User = Users.MyArray("usersBase.txt");
         }


    }






}


