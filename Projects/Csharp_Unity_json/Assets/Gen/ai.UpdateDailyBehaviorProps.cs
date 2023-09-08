
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;
using SimpleJSON;


namespace cfg.ai
{
public sealed partial class UpdateDailyBehaviorProps : ai.Service
{
    public UpdateDailyBehaviorProps(JSONNode _buf)  : base(_buf) 
    {
        { if(!_buf["satiety_key"].IsString) { throw new SerializationException(); }  SatietyKey = _buf["satiety_key"]; }
        { if(!_buf["energy_key"].IsString) { throw new SerializationException(); }  EnergyKey = _buf["energy_key"]; }
        { if(!_buf["mood_key"].IsString) { throw new SerializationException(); }  MoodKey = _buf["mood_key"]; }
        { if(!_buf["satiety_lower_threshold_key"].IsString) { throw new SerializationException(); }  SatietyLowerThresholdKey = _buf["satiety_lower_threshold_key"]; }
        { if(!_buf["satiety_upper_threshold_key"].IsString) { throw new SerializationException(); }  SatietyUpperThresholdKey = _buf["satiety_upper_threshold_key"]; }
        { if(!_buf["energy_lower_threshold_key"].IsString) { throw new SerializationException(); }  EnergyLowerThresholdKey = _buf["energy_lower_threshold_key"]; }
        { if(!_buf["energy_upper_threshold_key"].IsString) { throw new SerializationException(); }  EnergyUpperThresholdKey = _buf["energy_upper_threshold_key"]; }
        { if(!_buf["mood_lower_threshold_key"].IsString) { throw new SerializationException(); }  MoodLowerThresholdKey = _buf["mood_lower_threshold_key"]; }
        { if(!_buf["mood_upper_threshold_key"].IsString) { throw new SerializationException(); }  MoodUpperThresholdKey = _buf["mood_upper_threshold_key"]; }
    }

    public static UpdateDailyBehaviorProps DeserializeUpdateDailyBehaviorProps(JSONNode _buf)
    {
        return new ai.UpdateDailyBehaviorProps(_buf);
    }

    public readonly string SatietyKey;
    public readonly string EnergyKey;
    public readonly string MoodKey;
    public readonly string SatietyLowerThresholdKey;
    public readonly string SatietyUpperThresholdKey;
    public readonly string EnergyLowerThresholdKey;
    public readonly string EnergyUpperThresholdKey;
    public readonly string MoodLowerThresholdKey;
    public readonly string MoodUpperThresholdKey;
   
    public const int __ID__ = -61887372;
    public override int GetTypeId() => __ID__;

    public override void ResolveRef(Tables tables)
    {
        base.ResolveRef(tables);
        
        
        
        
        
        
        
        
        
    }

    public override string ToString()
    {
        return "{ "
        + "id:" + Id + ","
        + "nodeName:" + NodeName + ","
        + "satietyKey:" + SatietyKey + ","
        + "energyKey:" + EnergyKey + ","
        + "moodKey:" + MoodKey + ","
        + "satietyLowerThresholdKey:" + SatietyLowerThresholdKey + ","
        + "satietyUpperThresholdKey:" + SatietyUpperThresholdKey + ","
        + "energyLowerThresholdKey:" + EnergyLowerThresholdKey + ","
        + "energyUpperThresholdKey:" + EnergyUpperThresholdKey + ","
        + "moodLowerThresholdKey:" + MoodLowerThresholdKey + ","
        + "moodUpperThresholdKey:" + MoodUpperThresholdKey + ","
        + "}";
    }
}

}