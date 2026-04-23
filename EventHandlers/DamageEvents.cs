using Exiled.Events.EventArgs.Player;
using Exiled.API.Features.DamageHandlers;
using PlayerRoles;
using LegDamagePlugin.Services;

namespace LegDamagePlugin.EventHandlers
{
    public class DamageEvents
    {
        public void OnHurting(HurtingEventArgs ev)
        {
            if (ev.Player == null || ev.Attacker == null)
                return;

            if (ev.DamageHandler is not FirearmDamageHandler firearm)
                return;

            if (firearm.Hitbox != HitboxType.LeftLeg &&
                firearm.Hitbox != HitboxType.RightLeg)
                return;

            LegInjuryService.Apply(ev.Player, Plugin.Singleton.Config.LegSpeedMultiplier);
        }
    }
}