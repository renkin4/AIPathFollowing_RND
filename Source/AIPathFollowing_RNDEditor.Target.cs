// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class AIPathFollowing_RNDEditorTarget : TargetRules
{
	public AIPathFollowing_RNDEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "AIPathFollowing_RND" } );
	}
}
