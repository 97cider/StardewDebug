﻿using System;
using Microsoft.Xna.Framework;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewValley;
namespace StardewDebug
{
    public class ModEntry : Mod
{
    public override void Entry(IModHelper helper)
    {
        ControlEvents.KeyPressed += this.ControlEvents_KeyPress;
    }

    private void ControlEvents_KeyPress(object sender, EventArgsKeyPressed e)
    {
        this.Monitor.Log($"Player pressed {e.KeyPressed}.");
    }
}
}