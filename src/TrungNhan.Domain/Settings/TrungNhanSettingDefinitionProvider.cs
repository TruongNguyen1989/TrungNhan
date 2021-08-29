using Volo.Abp.Settings;

namespace TrungNhan.Settings
{
    public class TrungNhanSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(TrungNhanSettings.MySetting1));
        }
    }
}
