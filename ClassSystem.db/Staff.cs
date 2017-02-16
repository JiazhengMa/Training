using System;
using System.Collections.Generic;
using System.Text;

namespace ClassSystem.db
{
    public class Staff
    {
        public static void FillList(ref WindowsFormsAero.ListView list, string mode = "全部", string text = "")
        {
            if(text != "")
                SqlHelper.FillList(SqlHelper.ExecuteDt(string.Format("select * from ClassTable where name like '%{0}%'",text)), ref list);
            else
                SqlHelper.FillList(SqlHelper.ExecuteDt(string.Format("select * from ClassTable")), ref list);
        }

        public static int delClass(string id)
        {
            return SqlHelper.ExecuteSql(string.Format("DELETE FROM RecordTable WHERE id = {0}", id));
        }

        public static int addClass(string classid,string stuid)
        {
            return SqlHelper.ExecuteSql(string.Format("insert into RecordTable values({0},{1})", classid, stuid));
        }

        public static void FillList2(ref WindowsFormsAero.ListView list,string id)
        {
            SqlHelper.FillList(SqlHelper.ExecuteDt(string.Format("select a.id,b.name,b.credit,b.starttime,b.classtime,b.teacher from RecordTable as a left join ClassTable as b on a.classid = b.id left join UserTable as c on a.stuid = c.id where c.id = {0}",id)), ref list);
        }
    }
}
