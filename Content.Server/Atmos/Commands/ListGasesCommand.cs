﻿using Content.Server.Administration;
using Content.Server.Atmos.EntitySystems;
using Content.Shared.Administration;
using Robust.Shared.Console;
using Robust.Shared.GameObjects;

namespace Content.Server.Atmos.Commands
{
    [AdminCommand(AdminFlags.Debug)]
    public class ListGasesCommand : IConsoleCommand
    {
        public string Command => "listgases";
        public string Description => "Prints a list of gases and their indices.";
        public string Help => "listgases";

        public void Execute(IConsoleShell shell, string argStr, string[] args)
        {
            var atmosSystem = EntitySystem.Get<AtmosphereSystem>();

            foreach (var gasPrototype in atmosSystem.Gases)
            {
                shell.WriteLine($"{gasPrototype.Name} ID: {gasPrototype.ID}");
            }
        }
    }

}
