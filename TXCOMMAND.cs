using CommandSystem;
using Exiled.API.Features;
using RemoteAdmin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDTX
{
    [CommandHandler(typeof(ClientCommandHandler))]
    public class TXCOMMAND : ICommand
    {
        private Player player;
        public string Command => "tx";

        public string[] Aliases => new string[] { "tx" };

        public string Description => "DD投降指令";

        public bool Execute(ArraySegment<string> arguments, ICommandSender sender, out string response)
        {
            PlayerCommandSender playerCommandSender = sender as PlayerCommandSender;
            if (playerCommandSender == null)
            {
                response = "异常错误";
                return false;
            }
            player = Player.Get(playerCommandSender.PlayerId);
            if (player.Role.Type == PlayerRoles.RoleTypeId.ClassD)
            {
                if (!Plugin.Instance.txdd.Contains(player.Id))
                {
                    Plugin.Instance.txdd.Add(player.Id);
                    player.RankName = "投降人员";
                    player.RankColor = "";
                }
                response = "OK";
                return true;
            }
            response = "非DD无法使用这个指令";
            return false;
        }
    }
}
