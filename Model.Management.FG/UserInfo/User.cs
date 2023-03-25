using Model.Management.FG.AccountInfo;
using Model.Management.FG.StandardModel;
using SqlSugar;

namespace Model.Management.FG.UserInfo;

[SugarTable("User")]
public class User : StandardObject
{
    [SugarColumn(IsPrimaryKey = true,ColumnDataType = "char(36)")]
    public Guid UserId { get; set; }
    
    [SugarColumn(IsIgnore = true)]
    public UserDetail UserDetail { get; set; }
    
    [SugarColumn(IsIgnore = true)]
    public Account Account { get; set; }
}