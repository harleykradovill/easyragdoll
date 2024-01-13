-- Harley Kradovill
-- https://github.com/harleykradovill

print("EasyRagdoll Loaded")
local ragdollEnabled = false

Citizen.CreateThread(function ()
	while true do
		Citizen.Wait(0)
		if IsControlPressed(1, 47) then
		    ragdollEnabled = not ragdollEnabled
		    if ragdollEnabled then
                SetPedToRagdoll(GetPlayerPed(-1), 1000, 1000, 0, true, true, false)
                print("Toggle Ragdoll")
            end
		end
	end
end)