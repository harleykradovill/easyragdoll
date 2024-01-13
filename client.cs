// Created by Harley Kradovill
// https://github.com/harleykradovill

using CitizenFX.Core;
using CitizenFX.Core.Native;

public class EasyRagdoll : BaseScript {
    public EasyRagdoll() {
        Debug.WriteLine("EasyRagdoll Load")
        Tick += OnTick;
        EventHandlers["ragdoll:toggle"] += new Action(ToggleRagdoll);
    }

    private void OnTick() {
        if (Game.IsControlPressed(1, Control.Jump)) {
            TriggerServerEvent("ragdoll:toggle");
            Debug.WriteLine("Ragdoll event trig from client via tick")
        }
    }

    private void ToggleRagdoll() {
        API.SetPedToRagdoll(Game.PlayerPedId, 1000, 1000, 0, true, true, false);
        Debug.WriteLine("Ragdoll event trig from client via toggleRagdoll")
    }
}