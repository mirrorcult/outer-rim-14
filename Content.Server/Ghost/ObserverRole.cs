﻿using Content.Server.Roles;
﻿using Robust.Shared.Localization;

namespace Content.Server.Ghost
{
    /// <summary>
    /// This is used to mark Observers properly, as they get Minds
    /// </summary>
    public class ObserverRole : Role
    {
        public override string Name => Loc.GetString("observer-role-name");
        public override bool Antagonist => false;

        public ObserverRole(Mind.Mind mind) : base(mind)
        {
        }
    }
}
