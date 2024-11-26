// Fill out your copyright notice in the Description page of Project Settings.

using UnrealBuildTool;
using System.Collections.Generic;

public class LatencyTestTarget : TargetRules
{
	public LatencyTestTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		DefaultBuildSettings = BuildSettingsVersion.Latest;

		ExtraModuleNames.AddRange( new string[] { "LatencyTest" } );

		//BuildEnvironment = TargetBuildEnvironment.Unique;
		//bUseLoggingInShipping = true;
	}
}
