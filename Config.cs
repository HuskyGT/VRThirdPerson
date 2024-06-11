using System.IO;
using BepInEx;
using BepInEx.Configuration;
using UnityEngine;
using VRThirdPerson;

static internal class VRTPConfig
{
    public static ConfigFile config;

    static VRTPConfig()
    {
        config = new ConfigFile(Path.Combine(Paths.ConfigPath, "VRThirdPerson.cfg"), true);
    }
    public static void RefreshSettings() 
    {
        config.Reload();
        Plugin.tpCamOffsetValue = Mathf.Clamp(config.Bind("VR Third Person", "Third Person Camera Offset", 2, "Changes how far away your third person camera is from your gorilla").Value, 0.5f, 10000);
        Plugin.inverseCameraRotation = config.Bind("VR Third Person", "Inverted Camera Rotation", true, "Reverses your left thumbstick rotation around your gorilla").Value;
        Plugin.cameraClipping = config.Bind("VR Third Person", "Camera Clipping", true, "Toggles whether the third person camera can pass through objects").Value;
        Plugin.deadZone = Mathf.Clamp01(config.Bind("VR Third Person", "Dead Zone", 0.5f, "Thumbstick deadzone this is from 0-1 (0%-100%) for example 0.5 is a 50% thumbstick deadzone").Value);
    }
}


