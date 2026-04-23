using Exiled.API.Features;
using Exiled.Events;
using System;

namespace LegDamagePlugin
{
    public class Plugin : Plugin<Config>
    {
        public static Plugin Instance { get; private set; }

        private EventHandlers.DamageEvents _damageEvents;
        private EventHandlers.HealEvents _healEvents;

        public override string Name => "LegDamagePlugin";
        public override string Author => "VHS";
        public override Version Version => new Version(1, 0, 0);
        public override Version RequiredExiledVersion => new Version(8, 0, 0);

        public override void OnEnabled()
        {
            Instance = this;

            _damageEvents = new EventHandlers.DamageEvents();
            _healEvents = new EventHandlers.HealEvents();

            Player.Hurting += _damageEvents.OnHurting;
            Player.UsedItem += _healEvents.OnUsedItem;

            Log.Info("LegDamagePlugin activé.");

            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Player.Hurting -= _damageEvents.OnHurting;
            Player.UsedItem -= _healEvents.OnUsedItem;

            _damageEvents = null;
            _healEvents = null;
            Instance = null;

            Log.Info("LegDamagePlugin désactivé.");

            base.OnDisabled();
        }
    }
}