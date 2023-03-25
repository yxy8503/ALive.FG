using Model.Management.FG.StandardModel;
using SqlSugar;

namespace Model.Management.FG.UserInfo;

[SugarTable(tableName: "UserDetail", tableDescription: "Personal Information")]
public class UserDetail : StandardObject
{
    [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
    public int UserDetailId { get; set; }

    [SugarColumn(ColumnDataType = "varchar(100)")]
    public string UserName { get; set; }

    [SugarColumn(ColumnDataType = "char(8)")]
    public DateTime DateOfBirth { get; set; }

    [SugarColumn(ColumnDataType = "int", ColumnDescription = "0 - male, 1 - female")]
    public int Sex { get; set; }
}