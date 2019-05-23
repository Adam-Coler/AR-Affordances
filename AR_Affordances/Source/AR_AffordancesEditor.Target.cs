// Copyright Adam Williams 2019 

using UnrealBuildTool;
using System.Collections.Generic;

public class AR_AffordancesEditorTarget : TargetRules
{
	public AR_AffordancesEditorTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Editor;

		ExtraModuleNames.AddRange( new string[] { "AR_Affordances" } );
	}
}
