﻿using static Scripts.Structure;
using static Scripts.Structure.ArmorDefinition.ArmorType;
namespace Scripts {   
    partial class Parts {
        // Don't edit above this line
        ArmorDefinition LightPlateMod => new ArmorDefinition
        {
            SubtypeIds = new[] {
                "LargeArmorPanelLight",
                "LargeArmorSlopedSidePanelLight",
                "LargeArmorSlopedPanelLight",
                "LargeArmorHalfPanelLight",
                "LargeArmorQuarterPanelLight",
                "LargeArmor2x1SlopedPanelLight",
                "LargeArmor2x1SlopedPanelTipLight",
                "LargeArmor2x1SlopedSideBasePanelLight",
                "LargeArmor2x1SlopedSideTipPanelLight",
                "LargeArmor2x1SlopedSideBasePanelLightInv",
                "LargeArmor2x1SlopedSideTipPanelLightInv",
                "LargeArmorHalfSlopedPanelLight",
                "LargeArmor2x1HalfSlopedPanelLightRight",
                "LargeArmor2x1HalfSlopedTipPanelLightRight",
                "LargeArmor2x1HalfSlopedPanelLightLeft",
                "LargeArmor2x1HalfSlopedTipPanelLightLeft",
            },
            EnergeticResistance = 1f, //Resistance to Energy damage. 0.5f = 200% damage, 2f = 50% damage
            KineticResistance = 1f, //Resistance to Kinetic damage. Leave these as 1 for no effect
            Kind = Light, //Heavy, Light, NonArmor - which ammo damage multipliers to apply
        };
        ArmorDefinition HeavyPlateMod => new ArmorDefinition
        {
            SubtypeIds = new[] {
            "LargeArmorPanelHeavy",
            "LargeArmorSlopedSidePanelHeavy",
            "LargeArmorSlopedPanelHeavy",
            "LargeArmorHalfPanelHeavy",
            "LargeArmorQuarterPanelHeavy",
            "LargeArmor2x1SlopedPanelHeavy",
            "LargeArmor2x1SlopedPanelTipHeavy",
            "LargeArmor2x1SlopedSideBasePanelHeavy",
            "LargeArmor2x1SlopedSideTipPanelHeavy",
            "LargeArmor2x1SlopedSideBasePanelHeavyInv",
            "LargeArmor2x1SlopedSideTipPanelHeavyInv",
            "LargeArmorHalfSlopedPanelHeavy",
            "LargeArmor2x1HalfSlopedPanelHeavyRight",
            "LargeArmor2x1HalfSlopedTipPanelHeavyRight",
            "LargeArmor2x1HalfSlopedPanelHeavyLeft",
            "LargeArmor2x1HalfSlopedTipPanelHeavyLeft",
            },
            EnergeticResistance = 1f,
            KineticResistance = 1f,
            Kind = Heavy,
        };
		ArmorDefinition BusterBuff => new ArmorDefinition
        {
            SubtypeIds = new[] {
            "MA_Buster_ArmorBlock", 
			"MA_Buster_Window", 
			"MA_Buster_Conveyor",
			"MA_Buster_Camera",
			"MA_Buster_Passage_Crossing",
			"MA_Buster_Passage",
            "SC_RCS_Computer",
            },
            EnergeticResistance = 3f,
            KineticResistance = 3f,
            Kind = Heavy,
        };
        ArmorDefinition IonBuff => new ArmorDefinition
        {
            SubtypeIds = new[] {
            "AWGFocusDrive",
            "IonHeavyCovered",
            "LargeBlockLargeThrust",
            "AQD_LG_IonThrusterL_ArmoredSlope",
            "AQD_LG_IonThrusterL_Armored",
            "LargeBlockSmallThrust",
            "AQD_LG_IonThrusterS_Armored",
            "AQD_LG_IonThrusterS_ArmoredSlope",
            "SmallThrustSciFi",
            "LargeBlockSmallThrustSciFi",
			"LargeBlockLargeThrustSciFi",
            "LargeBlockLargeModularThruster",
            "LargeBlockSmallModularThruster",
			"StealthDrive",
            },
            EnergeticResistance = 4f,
            KineticResistance = 4f,
            Kind = NonArmor,
        };
        ArmorDefinition Rotormod => new ArmorDefinition
        {
            SubtypeIds = new[] {
			"LargeStator",
			"LargeRotor",
			"LargeAdvancedRotor",
			"LargeAdvancedStator",
			"LargeHinge",
			"LargeHingeHead",
			"BlinkDriveLarge",
			"MAR_1x1x1_AR_DualHead_Rotor",
			"MAR_1x1x1_AR_DualHead_Stator",
			"MAR_1x1x1_AR_DualHead_Rotor_forLG",
			"MAR_1x1x1_AR_Rotor_forLG",
			"MAR_1x1x1_AR_Half_Rotor_forLG",
			"MAR_1x1x1_AR_Rotor",
			"MAR_1x1x1_AR_Stator",
			"MAR_2x1x1_AR_Stator_ADJ",
			"MAR_1x1x1_AR_Half_Rotor",
			"MAR_1x1x1_AR_Half_Stator",
			"MAR_LG_Gyro_Half",
			"MAR_LG_1x1x1_AR_DualHead_Rotor",
			"MAR_LG_1x1x1_AR_DualHead_Stator",
			"MAR_LG_1x1x1_AR_Rotor",
			"MAR_LG_1x1x1_AR_Stator",
			"MAR_LG_1x1x1_AR_Half_Rotor",
			"MAR_LG_1x1x1_AR_Half_Stator",
			"MAR_LG_2x1x1_AR_Stator_ADJ",
			"MAR_LG_2x1x1_AR_Dualhead_Stator_ADJ",
			"TRR_5x5x1_TR_Rotor",
			"TRR_5x5x1_TR_Stator",
			"TRR_7x7x1_TR_Rotor",
			"TRR_7x7x1_TR_Stator",
			"TRR_9x9x1_TR_Rotor",
			"TRR_9x9x1_TR_Stator",
			"TRR_11x11x1_TR_Rotor",
			"TRR_11x11x1_TR_Stator",
			"TRR_LG_5x5x1_TR_Rotor",
			"TRR_LG_5x5x1_TR_Stator",
			"TRR_LG_7x7x1_TR_Rotor",
			"TRR_LG_7x7x1_TR_Stator",
			"TRR_LG_9x9x1_TR_Rotor",
			"TRR_LG_9x9x1_TR_Stator",
			"TRR_LG_11x11x1_TR_Rotor",
			"TRR_LG_11x11x1_TR_Stator",
            },
            EnergeticResistance = 25f,
            KineticResistance = 25f,
            Kind = NonArmor,
        };
		ArmorDefinition HeavyTurret => new ArmorDefinition
        {
            SubtypeIds = new[] {
			"K_SA_HeavyMetal_Gauss_PGBC",
			"BFTriCannon",
			"BattleshipCannonMK3",
			"RailgunxTurret",
			"C300mmTurret",
			"C500mmTurret",
			"MA_Gladius",
			"BFG_M",
			"HAS_Mammon",
			"ARYXMagnetarCannon",
			"MA_Tiger",
			"Starcore_PPC_Block",
			"MA_Fixed_T3",
			"MA_Derecho",
			"Odin_7x7_Battleshipcannon",
			"Odin_5x5_Battleshipcannon",
			"Odin_5x5_Battleshipcannon_Surface",
			"Odin_7x7_Battleshipcannon_Surface",
			"Odin_CoilCannon",
			"NHI_Heavy_Gun_Turret",
			"NHI_Mk3_Cannon_Turret",
			"NHI_Mk3_Cannon_Surface_Turret",
            "SC_Coil_Cannon",
            },
            EnergeticResistance = 1.5f,
            KineticResistance = 1.5f,
            Kind = NonArmor,
        };
		ArmorDefinition HeavyArmorBuff => new ArmorDefinition
        {
            SubtypeIds = new[] {
			"LargeHeavyBlockArmorSlope2Base",
			"LargeHeavyBlockArmorSlope2Tip",
			"LargeHeavyBlockArmorCorner2Base",
			"LargeHeavyBlockArmorCorner2Tip",
			"LargeHeavyBlockArmorInvCorner2Base",
			"LargeHeavyBlockArmorInvCorner2Tip",
			"LargeHeavyHalfArmorBlock",
			"LargeHeavyHalfSlopeArmorBlock",
			"LargeHeavyBlockArmorSlope2BaseSmooth",
			"LargeHeavyBlockArmorSlope2TipSmooth",
			"LargeHeavyBlockArmorCorner2BaseSmooth",
			"LargeHeavyBlockArmorCorner2TipSmooth",
			"LargeHeavyBlockArmorInvCorner2BaseSmooth",
			"LargeHeavyBlockArmorInvCorner2TipSmooth",
			"LargeHeavyBlockArmorRoundSlope",
			"LargeHeavyBlockArmorRoundCorner",
			"LargeHeavyBlockArmorRoundCornerInv",
			"LargeHeavyBlockArmorRoundedSlope",
			"LargeHeavyBlockArmorRoundedCorner",
			"LargeHeavyBlockArmorAngledSlope",
			"LargeHeavyBlockArmorAngledCorner",
			"LargeHeavyBlockArmorBlock",
			"LargeHeavyBlockArmorSlope",
			"LargeHeavyBlockArmorCorner",
			"LargeHeavyBlockArmorCornerInv",
			"LargeBlockHeavyArmorHalfSlopeInverted",
			"LargeBlockHeavyArmorHalfSlopeCorner",
			"LargeBlockHeavyArmorHalfSlopeCornerInverted",
			"LargeBlockHeavyArmorSlopedCornerTip",
			"LargeBlockHeavyArmorSlopedCornerBase",
			"LargeBlockHeavyArmorSlopedCorner",
			"LargeBlockHeavyArmorHalfSlopedCornerBase",
			"LargeBlockHeavyArmorHalfCorner",
			"LargeBlockHeavyArmorCornerSquare",
			"LargeBlockHeavyArmorHalfSlopedCorner",
			"LargeBlockHeavyArmorRaisedSlopedCorner",
			"LargeBlockHeavyArmorSlopeTransition",
			"LargeBlockHeavyArmorSlopeTransitionBase",
			"LargeBlockHeavyArmorSlopeTransitionMirrored",
			"LargeBlockHeavyArmorSlopeTransitionTip",
			"LargeBlockHeavyArmorSlopeTransitionTipMirrored",
			"LargeBlockHeavyArmorSquareSlopedCornerBase",
			"LargeBlockHeavyArmorSquareSlopedCornerTip",
			"LargeBlockHeavyArmorSquareSlopedCornerTipInv",
			"LargeBlockHeavyArmorCornerSquareInverted",
			"LargeBlockHeavyArmorSlopeTransitionBaseMirrored"
            },
            EnergeticResistance = 2f,
            KineticResistance = 2f,
            Kind = Heavy,
        };
		ArmorDefinition LightArmorBuff => new ArmorDefinition
        {
            SubtypeIds = new[] {
				"LargeBlockArmorBlock",
				"LargeBlockArmorSlope",
				"LargeBlockArmorCorner",
				"LargeBlockArmorCornerInv",
				"LargeBlockArmorRoundedSlope",
				"LargeBlockArmorRoundedCorner",
				"LargeBlockArmorAngledSlope",
				"LargeBlockArmorAngledCorner",
				"LargeBlockArmorRoundSlope",
				"LargeBlockArmorRoundCorner",
				"LargeBlockArmorRoundCornerInv",
				"LargeBlockArmorSlope2BaseSmooth",
				"LargeBlockArmorSlope2TipSmooth",
				"LargeBlockArmorCorner2BaseSmooth",
				"LargeBlockArmorCorner2TipSmooth",
				"LargeBlockArmorInvCorner2BaseSmooth",
				"LargeBlockArmorInvCorner2TipSmooth",
				"LargeBlockArmorSlope2Base",
				"LargeBlockArmorSlope2Tip",
				"LargeBlockArmorCorner2Base",
				"LargeBlockArmorCorner2Tip",
				"LargeBlockArmorInvCorner2Base",
				"LargeBlockArmorInvCorner2Tip",
				"LargeBlockArmorHalfSlopeInverted",
				"LargeBlockArmorHalfSlopeCorner",
				"LargeBlockArmorHalfSlopeCornerInverted",
				"LargeBlockArmorSlopedCornerTip",
				"LargeBlockArmorSlopedCornerBase",
				"LargeBlockArmorSlopedCorner",
				"LargeBlockArmorHalfSlopedCornerBase",
				"LargeBlockArmorHalfCorner",
				"LargeBlockArmorCornerSquare",
				"LargeBlockArmorCornerSquareInverted",
				"LargeBlockArmorHalfSlopedCorner",
				"LargeBlockArmorRaisedSlopedCorner",
				"LargeBlockArmorSlopeTransition",
				"LargeBlockArmorSlopeTransitionBase",
				"LargeBlockArmorSlopeTransitionBaseMirrored",
				"LargeBlockArmorSlopeTransitionMirrored",
				"LargeBlockArmorSlopeTransitionTip",
				"LargeBlockArmorSlopeTransitionTipMirrored",
				"LargeBlockArmorSquareSlopedCornerBase",
				"LargeBlockArmorSquareSlopedCornerTip",
				"LargeBlockArmorSquareSlopedCornerTipInv",
				"LargeHalfArmorBlock",
				"LargeHalfSlopeArmorBlock"
            },
            EnergeticResistance = 2f,
            KineticResistance = 2f,
            Kind = Light,
        };
        /*ArmorDefinition HeavyEnergyArmor => new ArmorDefinition
        {
            SubtypeIds = new[] {
                "LargeHeavyBlockArmorBlock_NRG",
                "LargeHeavyBlockArmorSlope_NRG",
                "LargeHeavyBlockArmorCorner_NRG",
                "LargeHeavyBlockArmorCornerInv_NRG",
                "LargeHeavyHalfArmorBlock_NRG",
                "LargeHeavyHalfSlopeArmorBlock_NRG",
                "LargeHeavyBlockArmorRoundedSlope_NRG",
                "LargeHeavyBlockArmorRoundedCorner_NRG",
                "LargeHeavyBlockArmorAngledSlope_NRG",
                "LargeHeavyBlockArmorAngledCorner_NRG",
                "LargeHeavyBlockArmorRoundSlope_NRG",
                "LargeHeavyBlockArmorRoundCorner_NRG",
                "LargeHeavyBlockArmorRoundCornerInv_NRG",
                "LargeHeavyBlockArmorSlope2BaseSmooth_NRG",
                "LargeHeavyBlockArmorSlope2TipSmooth_NRG",
                "LargeHeavyBlockArmorCorner2BaseSmooth_NRG",
                "LargeHeavyBlockArmorCorner2TipSmooth_NRG",
                "LargeHeavyBlockArmorInvCorner2BaseSmooth_NRG",
                "LargeHeavyBlockArmorInvCorner2TipSmooth_NRG",
                "LargeHeavyBlockArmorSlope2Base_NRG",
                "LargeHeavyBlockArmorSlope2Tip_NRG",
                "LargeHeavyBlockArmorCorner2Base_NRG",
                "LargeHeavyBlockArmorCorner2Tip_NRG",
                "LargeHeavyBlockArmorInvCorner2Base_NRG",
                "LargeHeavyBlockArmorInvCorner2Tip_NRG",
                "LargeBlockHeavyArmorHalfSlopeCorner_NRG",
                "LargeBlockHeavyArmorHalfSlopeInverted_NRG",
                "LargeBlockHeavyArmorHalfSlopeCornerInverted_NRG",
                "LargeBlockHeavyArmorSlopedCornerTip_NRG",
                "LargeBlockHeavyArmorSlopedCornerBase_NRG",
                "LargeBlockHeavyArmorSlopedCorner_NRG",
                "LargeBlockHeavyArmorHalfSlopedCornerBase_NRG",
                "LargeBlockHeavyArmorHalfCorner_NRG",
                "LargeBlockHeavyArmorCornerSquare_NRG",
                "LargeBlockHeavyArmorCornerSquareInverted_NRG",
                "LargeBlockHeavyArmorHalfSlopedCorner_NRG"
            },
            EnergeticResistance = 3.3f,
            KineticResistance = 1.5f,
            Kind = Heavy,
        };
		ArmorDefinition LightEnergyArmor => new ArmorDefinition
        {
            SubtypeIds = new[] {
                "LargeBlockArmorBlock_NRG",
                "LargeBlockArmorSlope_NRG",
                "LargeBlockArmorCorner_NRG",
                "LargeBlockArmorCornerInv_NRG",
                "LargeBlockArmorRoundedSlope_NRG",
                "LargeBlockArmorRoundedCorner_NRG",
                "LargeBlockArmorAngledSlope_NRG",
                "LargeBlockArmorAngledCorner_NRG",
                "LargeBlockArmorRoundSlope_NRG",
                "LargeBlockArmorRoundCorner_NRG",
                "LargeBlockArmorRoundCornerInv_NRG",
                "LargeBlockArmorSlope2BaseSmooth_NRG",
                "LargeBlockArmorSlope2TipSmooth_NRG",
                "LargeBlockArmorCorner2BaseSmooth_NRG",
                "LargeBlockArmorCorner2TipSmooth_NRG",
                "LargeBlockArmorInvCorner2BaseSmooth_NRG",
                "LargeBlockArmorInvCorner2TipSmooth_NRG",
                "LargeBlockArmorSlope2Base_NRG",
                "LargeBlockArmorSlope2Tip_NRG",
                "LargeBlockArmorCorner2Base_NRG",
                "LargeBlockArmorCorner2Tip_NRG",
                "LargeBlockArmorInvCorner2Base_NRG",
                "LargeBlockArmorInvCorner2Tip_NRG",
                "LargeHalfArmorBlock_NRG",
                "LargeHalfSlopeArmorBlock_NRG",
                "LargeBlockArmorHalfSlopeInverted_NRG",
                "LargeBlockArmorHalfSlopeCorner_NRG",
                "LargeBlockArmorHalfSlopeCornerInverted_NRG",
                "LargeBlockArmorSlopedCornerTip_NRG",
                "LargeBlockArmorSlopedCornerBase_NRG",
                "LargeBlockArmorSlopedCorner_NRG",
                "LargeBlockArmorHalfSlopedCornerBase_NRG",
                "LargeBlockArmorHalfCorner_NRG",
                "LargeBlockArmorCornerSquare_NRG",
                "LargeBlockArmorCornerSquareInverted_NRG",
                "LargeBlockArmorHalfSlopedCorner_NRG"
            },
            EnergeticResistance = 3.3f, //Resistance to Energy damage. 0.5f = 200% damage, 2f = 50% damage
            KineticResistance = 1f, //Resistance to Kinetic damage. Leave these as 1 for no effect
            Kind = Light, //Heavy, Light, NonArmor - which ammo damage multipliers to apply
        };
		ArmorDefinition HeavyKineticArmor => new ArmorDefinition
        {
            SubtypeIds = new[] {
                "LargeHeavyBlockArmorBlock_KIN",
                "LargeHeavyBlockArmorSlope_KIN",
                "LargeHeavyBlockArmorCorner_KIN",
                "LargeHeavyBlockArmorCornerInv_KIN",
                "LargeHeavyHalfArmorBlock_KIN",
                "LargeHeavyHalfSlopeArmorBlock_KIN",
                "LargeHeavyBlockArmorRoundedSlope_KIN",
                "LargeHeavyBlockArmorRoundedCorner_KIN",
                "LargeHeavyBlockArmorAngledSlope_KIN",
                "LargeHeavyBlockArmorAngledCorner_KIN",
                "LargeHeavyBlockArmorRoundSlope_KIN",
                "LargeHeavyBlockArmorRoundCorner_KIN",
                "LargeHeavyBlockArmorRoundCornerInv_KIN",
                "LargeHeavyBlockArmorSlope2BaseSmooth_KIN",
                "LargeHeavyBlockArmorSlope2TipSmooth_KIN",
                "LargeHeavyBlockArmorCorner2BaseSmooth_KIN",
                "LargeHeavyBlockArmorCorner2TipSmooth_KIN",
                "LargeHeavyBlockArmorInvCorner2BaseSmooth_KIN",
                "LargeHeavyBlockArmorInvCorner2TipSmooth_KIN",
                "LargeHeavyBlockArmorSlope2Base_KIN",
                "LargeHeavyBlockArmorSlope2Tip_KIN",
                "LargeHeavyBlockArmorCorner2Base_KIN",
                "LargeHeavyBlockArmorCorner2Tip_KIN",
                "LargeHeavyBlockArmorInvCorner2Base_KIN",
                "LargeHeavyBlockArmorInvCorner2Tip_KIN",
                "LargeBlockHeavyArmorHalfSlopeCorner_KIN",
                "LargeBlockHeavyArmorHalfSlopeInverted_KIN",
                "LargeBlockHeavyArmorHalfSlopeCornerInverted_KIN",
                "LargeBlockHeavyArmorSlopedCornerTip_KIN",
                "LargeBlockHeavyArmorSlopedCornerBase_KIN",
                "LargeBlockHeavyArmorSlopedCorner_KIN",
                "LargeBlockHeavyArmorHalfSlopedCornerBase_KIN",
                "LargeBlockHeavyArmorHalfCorner_KIN",
                "LargeBlockHeavyArmorCornerSquare_KIN",
                "LargeBlockHeavyArmorCornerSquareInverted_KIN",
                "LargeBlockHeavyArmorHalfSlopedCorner_KIN"
            },
            EnergeticResistance = 1.5f,
            KineticResistance = 3.3f,
            Kind = Heavy,
        };
		ArmorDefinition LightKineticArmor => new ArmorDefinition
        {
            SubtypeIds = new[] {
                "LargeBlockArmorBlock_KIN",
                "LargeBlockArmorSlope_KIN",
                "LargeBlockArmorCorner_KIN",
                "LargeBlockArmorCornerInv_KIN",
                "LargeBlockArmorRoundedSlope_KIN",
                "LargeBlockArmorRoundedCorner_KIN",
                "LargeBlockArmorAngledSlope_KIN",
                "LargeBlockArmorAngledCorner_KIN",
                "LargeBlockArmorRoundSlope_KIN",
                "LargeBlockArmorRoundCorner_KIN",
                "LargeBlockArmorRoundCornerInv_KIN",
                "LargeBlockArmorSlope2BaseSmooth_KIN",
                "LargeBlockArmorSlope2TipSmooth_KIN",
                "LargeBlockArmorCorner2BaseSmooth_KIN",
                "LargeBlockArmorCorner2TipSmooth_KIN",
                "LargeBlockArmorInvCorner2BaseSmooth_KIN",
                "LargeBlockArmorInvCorner2TipSmooth_KIN",
                "LargeBlockArmorSlope2Base_KIN",
                "LargeBlockArmorSlope2Tip_KIN",
                "LargeBlockArmorCorner2Base_KIN",
                "LargeBlockArmorCorner2Tip_KIN",
                "LargeBlockArmorInvCorner2Base_KIN",
                "LargeBlockArmorInvCorner2Tip_KIN",
                "LargeHalfArmorBlock_KIN",
                "LargeHalfSlopeArmorBlock_KIN",
                "LargeBlockArmorHalfSlopeInverted_KIN",
                "LargeBlockArmorHalfSlopeCorner_KIN",
                "LargeBlockArmorHalfSlopeCornerInverted_KIN",
                "LargeBlockArmorSlopedCornerTip_KIN",
                "LargeBlockArmorSlopedCornerBase_KIN",
                "LargeBlockArmorSlopedCorner_KIN",
                "LargeBlockArmorHalfSlopedCornerBase_KIN",
                "LargeBlockArmorHalfCorner_KIN",
                "LargeBlockArmorCornerSquare_KIN",
                "LargeBlockArmorCornerSquareInverted_KIN",
                "LargeBlockArmorHalfSlopedCorner_KIN"
            },
            EnergeticResistance = 1f, //Resistance to Energy damage. 0.5f = 200% damage, 2f = 50% damage
            KineticResistance = 3.3f, //Resistance to Kinetic damage. Leave these as 1 for no effect
            Kind = Light, //Heavy, Light, NonArmor - which ammo damage multipliers to apply
        };*/
		ArmorDefinition SixTwoFive => new ArmorDefinition
        {
            SubtypeIds = new[] {
			"StealthHeatSink"
            },
            EnergeticResistance = 6.25f, //Resistance to Energy damage. 0.5f = 200% damage, 2f = 50% damage
            KineticResistance = 6.25f, //Resistance to Kinetic damage. Leave these as 1 for no effect
            Kind = NonArmor, //Heavy, Light, NonArmor - which ammo damage multipliers to apply
        };
        
	}
}
