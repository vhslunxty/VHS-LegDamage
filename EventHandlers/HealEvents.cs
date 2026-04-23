using Exiled.Events.EventArgs.Player;
using Exiled.API.Enums;
using LegDamagePlugin.Services;

namespace LegDamagePlugin.EventHandlers
{
    public class HealEvents
    {
        public void OnUsedItem(UsedItemEventArgs ev)
        {
            if (ev.Item.Type == ItemType.Medkit)
            {
                LegInjuryService.Heal(ev.Player);
            }

            if (ev.Item.Type == ItemType.SCP500)
            {
                LegInjuryService.Reset(ev.Player);
            }
        }
    }
}