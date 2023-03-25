using SqlSugar;

namespace Model.Management.FG.StandardModel;

public class StandardObject
{
    [SugarColumn(InsertServerTime = true, ColumnDataType = "char(8)")]
    public DateTime CreateTime { get; set; }

    [SugarColumn(UpdateServerTime = true, ColumnDataType = "char(8)")]
    public DateTime UpdateTime { get; set; }

    [SugarColumn(UpdateServerTime = true, ColumnDataType = "char(8)")]
    public DateTime LastUpdateTime { get; set; }

    public string Status { get; set; }
}