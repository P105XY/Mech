// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class MechEditorTarget : TargetRules
{
	public MechEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;
		DefaultBuildSettings = BuildSettingsVersion.V5;
        bUseUnityBuild = true;

        ExtraModuleNames.AddRange( new string[] { "Mech", "MechGame" } );
	}
}
