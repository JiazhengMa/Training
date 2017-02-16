using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace ClassSystem.db
{
    public class StaffInfo
    {
        static  public void BanList(ref WindowsFormsAero.ListView list,string type = "0",string text="")
        {
            if (type == "0")
                    SqlHelper.FillList(SqlHelper.ExecuteDt(string.Format("select a.id,b.name,c.name from RecordTable as a left join ClassTable as b on a.classid = b.id left join UserTable as c on a.stuid = c.id")), ref list);
            if (type == "1")
                    SqlHelper.FillList(SqlHelper.ExecuteDt(string.Format("select a.id,b.name,c.name from RecordTable as a left join ClassTable as b on a.classid = b.id left join UserTable as c on a.stuid = c.id where b.name like '%{0}%'",text)), ref list);
            if (type == "2")
                SqlHelper.FillList(SqlHelper.ExecuteDt(string.Format("select a.id,b.name,c.name from RecordTable as a left join ClassTable as b on a.classid = b.id left join UserTable as c on a.stuid = c.id where c.name like '%{0}%'", text)), ref list);
        }
    }
}
