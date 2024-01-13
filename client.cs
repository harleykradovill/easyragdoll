// Created by Harley Kradovill
// https://github.com/harleykradovill

using CitizenFX.Core;
using CitizenFX.Core.Native;

public class EasyRagdoll : BaseScript {
    private bool ragdoll = false;
    private bool shownHelp = false;

    public EasyRagdoll() {
        EventHandlers["esx=:getSharedObject"] += new Action<dynamic>(esxObject => ESX = esxObject);
        Tick += OnTick;
    }

    private async void OnTick() {
        while ESX == null) {
            TriggerEvent("esx:getSharedObject", new object[] { new Action<dynamic>(esxObject => ESX = esxObject) });
            await Delay(0);
        }
        while (true) {
            await Delay(0);

            if (Game.IsControlJustPressed(2, Control.Context) && !Game.IsPedInAnyVehicle(Game.PlayerPedId, false)) {
                ragdoll = !ragdoll;
                if (!ragdoll)
                    shownHelp = false;
            }

            if (Config.stunShouldRagdoll && API.IsPedBeingStunned(Game.PlayerPedId))
                    ragdoll = true;
        }
    }
}