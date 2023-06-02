using Volo.Abp.Settings;

namespace FrontaTCG.Settings;

public class FrontaTCGSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(FrontaTCGSettings.MySetting1));
    }
}
