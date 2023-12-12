using UnrealBuildTool;

public class Platformer_ProjectTarget : TargetRules
{
	public Platformer_ProjectTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("Platformer_Project");
	}
}
