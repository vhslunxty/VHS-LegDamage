using Exiled.API.Interfaces;

namespace LegDamagePlugin
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;

        public float LegSpeedMultiplier { get; set; } = 0.6f;

        public float LegInjuryDuration { get; set; } = 0f;
    }
}