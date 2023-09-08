
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

package cfg.ai;

import luban.*;
import com.google.gson.JsonElement;
import com.google.gson.JsonObject;


public abstract class Decorator extends cfg.ai.Node {
    public Decorator(JsonObject _buf) { 
        super(_buf);
        flowAbortMode = _buf.get("flow_abort_mode").getAsInt();
    }

    public static Decorator deserialize(JsonObject _buf) {
        switch (_buf.get("$type").getAsString()) {
            case "UeLoop": return new cfg.ai.UeLoop(_buf);
            case "UeCooldown": return new cfg.ai.UeCooldown(_buf);
            case "UeTimeLimit": return new cfg.ai.UeTimeLimit(_buf);
            case "UeBlackboard": return new cfg.ai.UeBlackboard(_buf);
            case "UeForceSuccess": return new cfg.ai.UeForceSuccess(_buf);
            case "IsAtLocation": return new cfg.ai.IsAtLocation(_buf);
            case "DistanceLessThan": return new cfg.ai.DistanceLessThan(_buf);
            default: throw new SerializationException();
        }
    }

    public final int flowAbortMode;


    @Override
    public String toString() {
        return "{ "
        + "(format_field_name __code_style field.name):" + id + ","
        + "(format_field_name __code_style field.name):" + nodeName + ","
        + "(format_field_name __code_style field.name):" + flowAbortMode + ","
        + "}";
    }
}
