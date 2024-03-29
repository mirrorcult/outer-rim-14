using Content.Server.Worldgen.Populators.Debris;
using Robust.Shared.GameObjects;

namespace Content.Server.Worldgen.Components;

/// <summary>
/// Unloading system designed for grids.
/// </summary>
public class UnloadableComponent : Component
{
    public override string Name => "Unloadable";

    /// <summary>
    /// Populator to add with an UnpopulatedComponent should it unload again.
    /// </summary>
    public DebrisPopulator? PopulatorToAdd = null;

    /// <summary>
    /// Whether the "safety" has been triggered, and is preventing this entity from despawning.
    /// </summary>
    public bool Triggered = false;
}
