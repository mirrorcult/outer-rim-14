﻿using System.Collections.Generic;
using Robust.Server.Player;
using Robust.Shared.GameObjects;
using Robust.Shared.Map;
using Robust.Shared.Maths;

namespace Content.Server.Tabletop
{
    /// <summary>
    ///     A class for storing data about a running tabletop game.
    /// </summary>
    public class TabletopSession
    {
        /// <summary>
        ///     The center position of this session.
        /// </summary>
        public readonly MapCoordinates Position;

        /// <summary>
        ///     The set of players currently playing this tabletop game.
        /// </summary>
        public readonly Dictionary<IPlayerSession, TabletopSessionPlayerData> Players = new();

        /// <summary>
        ///     All entities bound to this session. If you create an entity for this session, you have to add it here.
        /// </summary>
        public readonly HashSet<EntityUid> Entities = new();

        public TabletopSession(MapId tabletopMap, Vector2 position)
        {
            Position = new MapCoordinates(position, tabletopMap);
        }
    }
}
