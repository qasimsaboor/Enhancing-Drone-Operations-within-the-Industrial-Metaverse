using System;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Provider;

    public class XRInput : MonoBehaviour
    {
        [SerializeField] XRController controller;
        [SerializeField] XRBinding[] bindings;

        private void Update()
        {
            foreach (var binding in bindings)
                binding.Update(controller.inputDevice);
        }
    }

    [Serializable]
    public class XRBinding
    {
        [SerializeField] XRButton button;
        [SerializeField] PressType pressType;
        [SerializeField] UnityEvent OnActive;

        bool isPressed;
        bool wasPressed;

        public void Update(InputDevice device)
        {
            isPressed = XRStatics.IsPressed(device, button);
            bool active = false;

            switch (pressType)
            { 
                case PressType.Continuous: active = isPressed; break;
                case PressType.Begin: active = isPressed && !wasPressed; break;
                case PressType.End: active = !isPressed && wasPressed; break;
            }

            if (active) OnActive.Invoke();
            wasPressed = isPressed;
        }
    }

    public enum XRButton
    {
        Trigger,
        Grip,
        Primary,
        PrimaryTouch,
        Secondary,
        SecondaryTouch,
        Primary2DAxisClick,
        Primary2DAxisTouch
    }

    public enum PressType
    {
        Begin,
        End,
        Continuous  
    }

    public static class XRStatics
    {
        public static InputFeatureUsage<bool> GetFeature(XRButton button)
        {
            switch (button)
            {
                case XRButton.Trigger: return CommonUsages.triggerButton;
                case XRButton.Grip: return CommonUsages.gripButton;
                case XRButton.Primary: return CommonUsages.primaryButton;
                case XRButton.PrimaryTouch: return CommonUsages.primaryTouch;
                case XRButton.Secondary: return CommonUsages.secondaryButton;
                case XRButton.SecondaryTouch: return CommonUsages.secondaryTouch;
                case XRButton.Primary2DAxisClick: return CommonUsages.primary2DAxisClick;
                case XRButton.Primary2DAxisTouch: return CommonUsages.primary2DAxisTouch;
                default: Debug.LogError("button " + button + " not found"); return CommonUsages.triggerButton;
            }
        }

        public static bool IsPressed(InputDevice device, XRButton button)
        {
            device.TryGetFeatureValue(GetFeature(button), out bool value);
            return value;
        }

        public static Vector2 Get2DAxisValue(InputDevice device)
        {
            device.TryGetFeatureValue(CommonUsages.primary2DAxis, out Vector2 value);
            return value;
        }
    }
