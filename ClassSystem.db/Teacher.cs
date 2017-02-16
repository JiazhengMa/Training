using System;
using System.Collections.Generic;
using System.Text;

namespace ClassSystem.db
{
    public class Teacher
    {
        public static int addClass(string name,string credit,string starttime,string teacher,string classtime) 
        {
           return SqlHelper.ExecuteSql(string.Format("insert into ClassTable values('{0}',10,{1},'{2}','{3}',{4})",name,credit,starttime,classtime,teacher));
        }

        public static int updataClass(string name, string credit, string starttime, string teacher, string classtime,string id)
        {
            return SqlHelper.ExecuteSql(string.Format("update ClassTable name='{0}',credit={1},starttime='{2}',classtime={3},teacher='{4}' where id={5}", name, credit, starttime, classtime, teacher,id));
        }

        public static void FillList(ref WindowsFormsAero.ListView list,string mode = "0", string text = "")
        {
            if(mode == "0")
                SqlHelper.FillList(SqlHelper.ExecuteDt("select * from ClassTable"),ref list);
            if(mode == "1")
                SqlHelper.FillList(SqlHelper.ExecuteDt(string.Format("select * from ClassTable where name like '%{0}%'",text)), ref list);
            if (mode == "2")
                SqlHelper.FillList(SqlHelper.ExecuteDt(string.Format("select * from ClassTable where teacher like '%{0}%'", text)), ref list);
        }
    }
}
