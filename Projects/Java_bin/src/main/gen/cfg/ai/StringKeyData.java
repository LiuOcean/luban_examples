
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.ai;

import luban.*;


public final class StringKeyData extends cfg.ai.KeyData {
    public StringKeyData(ByteBuf _buf) { 
        super(_buf);
        value = _buf.readString();
    }

    public static StringKeyData deserialize(ByteBuf _buf) {
            return new cfg.ai.StringKeyData(_buf);
    }

    public final String value;

    public static final int __ID__ = -307888654;
    
    @Override
    public int getTypeId() { return __ID__; }

    @Override
    public String toString() {
        return "{ "
        + "(format_field_name __code_style field.name):" + value + ","
        + "}";
    }
}
