using GorillaNetworking;
using UnityEngine;

public class VRInput : MonoBehaviour
{
    public static VRControllerInput leftHand, rightHand;
    public static bool OnSteam = false;
    void Awake()
    {
        OnSteam = PlayFabAuthenticator.instance.platform.ToUpper() == "STEAM";
        leftHand = new VRControllerInput(true);
        rightHand = new VRControllerInput(false);
    }
    public void Update() => UpdateInput();

    public void UpdateInput()
    {
        leftHand?.UpdateInput();
        rightHand?.UpdateInput();
    }
}
