using UnrealBuildTool;

public class VirtualStudioTarget : TargetRules
{
	public VirtualStudioTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("VirtualStudio");
	}
}
