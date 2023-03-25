using Model.Management.FG.IBaseModel;

namespace Model.Management.FG.UserInfo;

public class User : StandardObject
{
    public Guid UserId { get; set; }
}