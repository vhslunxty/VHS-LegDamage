using Exiled.API.Features;
using System.Collections.Generic;

namespace LegDamagePlugin.Services
{
    public static class LegInjuryService
    {
        private static readonly Dictionary<Player, float> InjuredPlayers = new();

        public static void Apply(Player player, float speedMultiplier)
        {
            if (InjuredPlayers.ContainsKey(player))
                return;

            InjuredPlayers[player] = speedMultiplier;

            player.MovementSpeedMultiplier *= speedMultiplier;
            player.ShowHint("<color=red>Ta jambe est blessée, tu boites.</color>", 3);
        }

        public static void Heal(Player player)
        {
            if (!InjuredPlayers.TryGetValue(player, out float multiplier))
                return;

            player.MovementSpeedMultiplier /= multiplier;
            InjuredPlayers.Remove(player);

            player.ShowHint("<color=green>Ta jambe est soignée.</color>", 3);
        }

        public static void Reset(Player player)
        {
            Heal(player);
        }
    }
}