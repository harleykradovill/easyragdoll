// Created by Harley Kradovill
// https://github.com/harleykradovill

using CitizenFX.Core;
using CitizenFX.Core.Native;
using CitizenFX.Core.UI;

public class EasyRagdoll : BaseScript {
    private bool ragdolled = false;
    private Control ragdollKey = Control.MultiplayerInfo;

    public Ragdoll() {
    Tick += OnTick;
    RegisterCommand("toggleragdoll", new Action(ToggleRagdoll), false);

    if (API.RegisterKeyMapping("toggleRagdoll", "Toggle Ragdoll", "keyboard", "Z")) {
        Debug.WriteLine("Keybind registered");
    } else {
        Debug.WriteLine("Keybind failed to register");
    }



    }

}