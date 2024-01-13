// Created by Harley Kradovill
// https://github.com/harleykradovill

using CitizenFX.Core;
using CitizenFX.Core.Native;

public class EasyRagdoll : BaseScript {
    public EasyRagdoll() {
        Tick += OnTick;
        EventHandlers["ragdoll:toggle"] += new Action(ToggleRagdoll);
    }

    private void OnTick() {
        if (Game.IsControlPressed(1, Control.Jump)) {
            TriggerServerEvent("ragdoll:toggle");
        }
    }

    private void ToggleRagdoll() {
        API.SetPedToRagdoll(Game.PlayerPedId, 1000, 1000, 0, true, true, false);
    }
}