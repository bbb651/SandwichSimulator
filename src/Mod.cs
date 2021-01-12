using System;
using System.Collections.Generic;
using System.Reflection;

[assembly: AssemblyTitle("Sandwich Simulator")]

[assembly: AssemblyCompany("bbb651")]

[assembly: AssemblyDescription("The real sandwiches are the friends you made along the way.")]

[assembly: AssemblyVersion("1.0.0.0")]

namespace DuckGame.SandwichSimulator {
    public class MyMod : Mod {
        public override Priority priority {
            get { return base.priority; }
        }

        protected override void OnPreInitialize() {
            base.OnPreInitialize();
            DevConsole.AddCommand(new CMD("makemeasandwich", new CMD.Argument[] { },
                delegate (CMD cmd) {
                    DevConsole.Log("No.", Color.Red);
                }) {
                cheat = false,
                hidden = true,
                description = "Makes you a sandwich.",
                aliases = new List<String> { "dontmakemeasandwich", "isthiscommandreallynecessary" }
            });

        }

        protected override void OnPostInitialize() {
            base.OnPostInitialize();
        }
    }
}
