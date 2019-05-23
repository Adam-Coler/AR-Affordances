// Copyright Adam Williams 2019 

using UnrealBuildTool;
using System.Collections.Generic;

public class AR_AffordancesTarget : TargetRules
{
	public AR_AffordancesTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;

		ExtraModuleNames.AddRange( new string[] { "AR_Affordances" } );
	}
}
