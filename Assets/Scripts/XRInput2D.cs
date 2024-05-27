using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class XRInput2D : MonoBehaviour
{

    [SerializeField] XRController controller;
    [SerializeField] Vector2Event OnActive;
    [SerializeField] bool alwaysActive;



    private void Update()
    {
        if (alwaysActive)
            GetAxisValue();
    }

    public void GetAxisValue()
    {
        OnActive.Invoke(XRStatics.Get2DAxisValue(controller.inputDevice));
    }
}
