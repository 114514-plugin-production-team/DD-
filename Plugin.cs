using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDTX
{
    public class Plugin : Plugin<Class1>
    {
        public List<int> txdd = new List<int>();
        public override string Author => "114514(QQ3145186196)";
        public override string Name => "DD投降";
        public override Version Version => new Version(1, 1, 2);
        public static Plugin Instance { get; private set; }
        public override void OnEnabled()
        {
            Instance = this;
            Exiled.Events.Handlers.Player.Hurting += OnHurting;
            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            Instance = null;
            Exiled.Events.Handlers.Player.Hurting -= OnHurting;
            base.OnDisabled();
        }
        public void OnHurting(HurtingEventArgs ev)
        {
            if (ev.Player != null)
            {
                if (txdd.Contains(ev.Player.Id))
                {
                    if (ev.Attacker.Role.Side == Exiled.API.Enums.Side.Mtf)
                    {
                        ev.IsAllowed = true;
                    }
                }
            }
        }
    }
}
