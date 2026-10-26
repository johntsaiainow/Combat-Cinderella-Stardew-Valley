using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewValley;

namespace KoResidenceInteractions;

public sealed class ModEntry : Mod
{
    private bool securityArmed;
    private readonly Dictionary<Point, string> messages = new()
    {
        [new Point(6, 7)] = "Carrie's desk: duty rosters, neatly aligned notebooks, and an old NJROTC photograph.",
        [new Point(35, 7)] = "Natalica's desk: a concealed microphone, a soldering iron, and suspiciously many cat treats.",
        [new Point(21, 14)] = "The family television. A quiet evening is a rare luxury for the Ko family.",
        [new Point(7, 17)] = "The kitchen smells of freshly prepared dinner.",
        [new Point(8, 25)] = "Aether Gear's engineering bench: oscilloscopes, prototype boards, and unfinished projects.",
        [new Point(34, 25)] = "HESTIA home command terminal."
    };

    public override void Entry(IModHelper helper)
    {
        helper.Events.Input.ButtonPressed += OnButtonPressed;
    }

    private void OnButtonPressed(object? sender, ButtonPressedEventArgs e)
    {
        if (!Context.IsWorldReady || !e.Button.IsActionButton() || Game1.activeClickableMenu is not null)
            return;
        if (Game1.currentLocation?.Name is not string name || !name.EndsWith("_KoResidence", StringComparison.Ordinal))
            return;
        Vector2 target = Game1.player.GetGrabTile();
        Point tile = new((int)target.X, (int)target.Y);
        foreach (var pair in messages)
        {
            if (Math.Abs(pair.Key.X - tile.X) > 1 || Math.Abs(pair.Key.Y - tile.Y) > 1)
                continue;
            if (pair.Key == new Point(34, 25))
            {
                securityArmed = !securityArmed;
                Game1.drawObjectDialogue($"HESTIA: Home security {(securityArmed ? "armed" : "disarmed")}. All family members accounted for.");
            }
            else Game1.drawObjectDialogue(pair.Value);
            Helper.Input.Suppress(e.Button);
            return;
        }
    }
}
