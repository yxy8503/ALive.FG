using Model.Management.FG.StandardModel;
using SqlSugar;

namespace Model.Management.FG.AccountInfo;

[SugarTable(tableName: "AccountDetail", tableDescription: "Personal Account Information")]
public class AccountDetail : StandardObject
{
    [SugarColumn(IsPrimaryKey = true, IsIdentity = true)]
    public int AccountDetailId { get; set; }

    [SugarColumn(ColumnDataType = "double")]
    public double Balance { get; set; }

    [SugarColumn(ColumnDataType = "char(1)")]
    public string Identity { get; set; }
    
}