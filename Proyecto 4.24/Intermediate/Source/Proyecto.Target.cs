using UnrealBuildTool;

public class ProyectoTarget : TargetRules
{
	public ProyectoTarget(TargetInfo Target) : base(Target)
	{
		Type = TargetType.Game;
		ExtraModuleNames.Add("Proyecto");
	}
}
