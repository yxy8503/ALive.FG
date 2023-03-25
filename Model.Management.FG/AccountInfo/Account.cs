using Model.Management.FG.StandardModel;
using Model.Management.FG.UserInfo;
using SqlSugar;

namespace Model.Management.FG.AccountInfo;

[SugarTable("Account")]
public class Account : StandardObject
{
    [SugarColumn(IsPrimaryKey = true)]
    public Guid AccountId { get; set; }
    
    [SugarColumn(ColumnDataType = "char(18)")]
    public string AccountName { get; set; }
    
    [SugarColumn(ColumnDataType = "varchar(100)")]
    public string AccountPwd { get; set; }
    
    [SugarColumn(IsIgnore = true)]
    public AccountDetail AccountDetail { get; set; }
    
    [SugarColumn(IsIgnore = true)]
    public User User { get; set; }
}