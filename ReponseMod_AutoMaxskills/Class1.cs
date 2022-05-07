using Rocket.Core.Plugins;
using Rocket.Unturned;
using Rocket.Unturned.Events;
using Rocket.Unturned.Player;
using SDG.Unturned;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ReponseMod_AutoMaxskills
{
    public class Class1 : RocketPlugin<Config>
    {
        protected override void Load()
        {
            base.Load();    
            U.Events.OnPlayerConnected += j;
            UnturnedPlayerEvents.OnPlayerRevive += r;
        }

        private void r(UnturnedPlayer player, Vector3 position, byte angle)
        {
            if (Configuration.Instance.WarningMessage)
            {
                ChatManager.serverSendMessage(Configuration.Instance.WarningMessageText, Color.white, null, player.SteamPlayer(), EChatMode.SAY, Configuration.Instance.WarningLogo, true);
            }
            player.Player.skills.ServerUnlockAllSkills();
        }

        private void j(UnturnedPlayer player)
        {
            if (Configuration.Instance.WarningMessage)
            {
                ChatManager.serverSendMessage(Configuration.Instance.WarningMessageText, Color.white, null, player.SteamPlayer(), EChatMode.SAY, Configuration.Instance.WarningLogo, true);
            }
            player.Player.skills.ServerUnlockAllSkills();
        }
    }
}
