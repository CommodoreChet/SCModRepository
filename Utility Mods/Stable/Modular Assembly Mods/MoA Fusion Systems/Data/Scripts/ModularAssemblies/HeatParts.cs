﻿using System;
using System.Collections.Generic;
using StarCore.FusionSystems.FusionParts;
using StarCore.FusionSystems.HeatParts;
using VRageMath;
using static StarCore.FusionSystems.Communication.DefinitionDefs;

namespace StarCore.FusionSystems
{
    internal partial class ModularDefinition
    {
        // You can declare functions in here, and they are shared between all other ModularDefinition files.

        // This is the important bit.
        private ModularPhysicalDefinition ModularHeat => new ModularPhysicalDefinition
        {
            // Unique name of the definition.
            Name = "Modular_Heat",

            OnInit = () => { SFusionManager.I.HeatDefinition = this; },

            // Triggers whenever a new part is added to an assembly.
            OnPartAdd = HeatManager.I.OnPartAdd,

            // Triggers whenever a part is removed from an assembly.
            OnPartRemove = HeatManager.I.OnPartRemove,

            // Triggers whenever a part is destroyed, simultaneously with OnPartRemove
            OnPartDestroy = null,

            // The most important block in an assembly. Connection checking starts here.
            BaseBlockSubtype = null,

            // All SubtypeIds that can be part of this assembly.
            AllowedBlockSubtypes = new[]
            {
                "Heat_Heatsink",
                "Heat_FlatRadiator"
            },

            // Allowed connection directions & whitelists, measured in blocks.
            // If an allowed SubtypeId is not included here, connections are allowed on all sides.
            // If the connection type whitelist is empty, all allowed subtypes may connect on that side.
            AllowedConnections = new Dictionary<string, Dictionary<Vector3I, string[]>>
            {
                ["Heat_Heatsink"] = new Dictionary<Vector3I, string[]>
                {
                    [Vector3I.Up] = Array.Empty<string>(),
                    [Vector3I.Down] = Array.Empty<string>(),
                    [Vector3I.Left] = Array.Empty<string>(),
                    [Vector3I.Right] = Array.Empty<string>()
                },
                ["Heat_FlatRadiator"] = new Dictionary<Vector3I, string[]>
                {
                    [Vector3I.Forward] = Array.Empty<string>(),
                    [Vector3I.Up] = new[]
                    {
                        "Heat_FlatRadiator"
                    },
                    [Vector3I.Down] = new[]
                    {
                        "Heat_FlatRadiator"
                    },
                    [Vector3I.Left] = new[]
                    {
                        "Heat_FlatRadiator"
                    },
                    [Vector3I.Right] = new[]
                    {
                        "Heat_FlatRadiator"
                    }
                }
            }
        };
    }
}