﻿using Robust.Shared.GameStates;

namespace Content.Shared._RMC14.Medical.Surgery.Tools;

[RegisterComponent, NetworkedComponent]
[Access(typeof(SharedCMSurgerySystem))]
public sealed partial class CMSurgicalDrillComponent : Component, ICMSurgeryToolComponent
{
    public string ToolName => "a surgical drill";
}
