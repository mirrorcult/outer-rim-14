﻿using Content.Shared.Light.Component;
using Robust.Shared.Audio;
using Robust.Shared.GameObjects;

namespace Content.Client.Light.Components
{
    /// <summary>
    ///     Component that represents a handheld expendable light which can be activated and eventually dies over time.
    /// </summary>
    [RegisterComponent]
    public class ExpendableLightComponent : SharedExpendableLightComponent
    {
        public IPlayingAudioStream? PlayingStream { get; set; }
    }
}
