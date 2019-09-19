using JetBrains.Annotations;
using WellFired.Command.Skins;
using WellFired.Command.Skins.Customisation;
using WellFired.Json;

namespace WellFired.Command
{
    public enum Theme
    {
        Default,
        Light,
        SkyBlue,
        Green,
        Purple,
        DarkOlive
    }
    
    public class Settings
    {
        [PublicAPI]
        public Theme Theme { get; set; } = Theme.Default;
        
        [PublicAPI]
        [JsonIgnore]
        public SkinData SkinData { get; set; }

        public void LoadSkinData()
        {
            switch (Theme)
            {
                case Theme.Default:
                    SkinData = SkinData.From(new DarkSkin());
                    break;
                case Theme.Light:
                    SkinData = SkinData.From(new LightSkin());
                    break;
                case Theme.SkyBlue:
                    SkinData = SkinData.From(new SkyBlueSkin());
                    break;
                case Theme.Green:
                    SkinData = SkinData.From(new GreenSkin());
                    break;
                case Theme.Purple:
                    SkinData = SkinData.From(new PurpleSkin());
                    break;
                case Theme.DarkOlive:
                    SkinData = SkinData.From(new DarkOlive());
                    break;
                default:
                    SkinData = SkinData.From(new DarkSkin());
                    break;
            }
        }
    }
}