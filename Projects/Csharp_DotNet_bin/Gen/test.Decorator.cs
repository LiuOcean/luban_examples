
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;


namespace cfg.test
{
public sealed partial class Decorator : test.ItemBase
{
    public Decorator(ByteBuf _buf)  : base(_buf) 
    {
        Duration = _buf.ReadInt();
    }

    public static Decorator DeserializeDecorator(ByteBuf _buf)
    {
        return new test.Decorator(_buf);
    }

    public readonly int Duration;
   
    public const int __ID__ = -625155649;
    public override int GetTypeId() => __ID__;

    public override void ResolveRef(Tables tables)
    {
        base.ResolveRef(tables);
        
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + Id + ","
        + "name:" + Name + ","
        + "desc:" + Desc + ","
        + "duration:" + Duration + ","
        + "}";
    }
}

}