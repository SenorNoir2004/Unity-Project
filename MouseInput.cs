// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Players/Mouse.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @MouseInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @MouseInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Mouse"",
    ""maps"": [
        {
            ""name"": ""Mouse"",
            ""id"": ""d71aae4e-8da8-4fd1-8514-2b6c23626145"",
            ""actions"": [
                {
                    ""name"": ""MouseClick"",
                    ""type"": ""Button"",
                    ""id"": ""337bdb53-6048-41a8-837d-7d90c1a0bf7f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MousePosistion"",
                    ""type"": ""Value"",
                    ""id"": ""ef191485-1571-45f3-a3e0-7fdeb632e381"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": ""Tap""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""fe705df6-6508-4b89-a960-c723f8d60914"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": ""Tap"",
                    ""processors"": ""Normalize"",
                    ""groups"": """",
                    ""action"": ""MouseClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""37189535-9c6d-46a3-be37-c1bb830fe5d8"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MousePosistion"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Mouse
        m_Mouse = asset.FindActionMap("Mouse", throwIfNotFound: true);
        m_Mouse_MouseClick = m_Mouse.FindAction("MouseClick", throwIfNotFound: true);
        m_Mouse_MousePosistion = m_Mouse.FindAction("MousePosistion", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Mouse
    private readonly InputActionMap m_Mouse;
    private IMouseActions m_MouseActionsCallbackInterface;
    private readonly InputAction m_Mouse_MouseClick;
    private readonly InputAction m_Mouse_MousePosistion;
    public struct MouseActions
    {
        private @MouseInput m_Wrapper;
        public MouseActions(@MouseInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @MouseClick => m_Wrapper.m_Mouse_MouseClick;
        public InputAction @MousePosistion => m_Wrapper.m_Mouse_MousePosistion;
        public InputActionMap Get() { return m_Wrapper.m_Mouse; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MouseActions set) { return set.Get(); }
        public void SetCallbacks(IMouseActions instance)
        {
            if (m_Wrapper.m_MouseActionsCallbackInterface != null)
            {
                @MouseClick.started -= m_Wrapper.m_MouseActionsCallbackInterface.OnMouseClick;
                @MouseClick.performed -= m_Wrapper.m_MouseActionsCallbackInterface.OnMouseClick;
                @MouseClick.canceled -= m_Wrapper.m_MouseActionsCallbackInterface.OnMouseClick;
                @MousePosistion.started -= m_Wrapper.m_MouseActionsCallbackInterface.OnMousePosistion;
                @MousePosistion.performed -= m_Wrapper.m_MouseActionsCallbackInterface.OnMousePosistion;
                @MousePosistion.canceled -= m_Wrapper.m_MouseActionsCallbackInterface.OnMousePosistion;
            }
            m_Wrapper.m_MouseActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MouseClick.started += instance.OnMouseClick;
                @MouseClick.performed += instance.OnMouseClick;
                @MouseClick.canceled += instance.OnMouseClick;
                @MousePosistion.started += instance.OnMousePosistion;
                @MousePosistion.performed += instance.OnMousePosistion;
                @MousePosistion.canceled += instance.OnMousePosistion;
            }
        }
    }
    public MouseActions @Mouse => new MouseActions(this);
    public interface IMouseActions
    {
        void OnMouseClick(InputAction.CallbackContext context);
        void OnMousePosistion(InputAction.CallbackContext context);
    }
}
