using Rocket.API;

namespace ReponseMod_AutoMaxskills
{
    public class Config : IRocketPluginConfiguration
    {
        public bool WarningMessage;
        public string WarningMessageText;
        public string WarningLogo;

        public void LoadDefaults()
        {
            WarningMessage = true;
            WarningMessageText = "Your <color=orange>Skills</color> Have Been <color=green>Successfully</color> Completed!";
            WarningLogo = "https://media.discordapp.net/attachments/959142220366237796/962008357990977626/122.png";
        }
    }
}