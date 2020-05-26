// GENERATED AUTOMATICALLY FROM 'Assets/Controls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Controls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""MapEditor"",
            ""id"": ""9831e407-f7dc-4402-b3b0-45ba0bd2450f"",
            ""actions"": [
                {
                    ""name"": ""MousePosition"",
                    ""type"": ""Value"",
                    ""id"": ""2a99c43a-55f9-47de-a571-72f613ac62bf"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeftMouseButton"",
                    ""type"": ""Button"",
                    ""id"": ""70fd059a-e5b7-47e3-9631-8b8518403afd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LeftMouseButtonHold"",
                    ""type"": ""Button"",
                    ""id"": ""79e18c97-241f-468e-876f-678a883ccab0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Hold""
                },
                {
                    ""name"": ""RightMouseButton"",
                    ""type"": ""Button"",
                    ""id"": ""dad97b56-d24e-4775-a7ce-69b4b0dbcd4a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MiddleMouseButton"",
                    ""type"": ""Button"",
                    ""id"": ""f5405914-536e-424d-97a6-5d02ad57dd89"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""736876a8-1e19-4314-a0df-f2edb7f61b70"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MousePosition"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""79ffc3d9-2438-4975-ae29-d63af562827e"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftMouseButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""66db4bfe-dcf1-4d34-b03c-c22171c869cc"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RightMouseButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d5e5fbff-2950-4d0c-96fe-3fdd684e67b5"",
                    ""path"": ""<Mouse>/middleButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MiddleMouseButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b5c8f5e3-f1b0-4b48-a74b-01f9ed172662"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LeftMouseButtonHold"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // MapEditor
        m_MapEditor = asset.FindActionMap("MapEditor", throwIfNotFound: true);
        m_MapEditor_MousePosition = m_MapEditor.FindAction("MousePosition", throwIfNotFound: true);
        m_MapEditor_LeftMouseButton = m_MapEditor.FindAction("LeftMouseButton", throwIfNotFound: true);
        m_MapEditor_LeftMouseButtonHold = m_MapEditor.FindAction("LeftMouseButtonHold", throwIfNotFound: true);
        m_MapEditor_RightMouseButton = m_MapEditor.FindAction("RightMouseButton", throwIfNotFound: true);
        m_MapEditor_MiddleMouseButton = m_MapEditor.FindAction("MiddleMouseButton", throwIfNotFound: true);
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

    // MapEditor
    private readonly InputActionMap m_MapEditor;
    private IMapEditorActions m_MapEditorActionsCallbackInterface;
    private readonly InputAction m_MapEditor_MousePosition;
    private readonly InputAction m_MapEditor_LeftMouseButton;
    private readonly InputAction m_MapEditor_LeftMouseButtonHold;
    private readonly InputAction m_MapEditor_RightMouseButton;
    private readonly InputAction m_MapEditor_MiddleMouseButton;
    public struct MapEditorActions
    {
        private @Controls m_Wrapper;
        public MapEditorActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @MousePosition => m_Wrapper.m_MapEditor_MousePosition;
        public InputAction @LeftMouseButton => m_Wrapper.m_MapEditor_LeftMouseButton;
        public InputAction @LeftMouseButtonHold => m_Wrapper.m_MapEditor_LeftMouseButtonHold;
        public InputAction @RightMouseButton => m_Wrapper.m_MapEditor_RightMouseButton;
        public InputAction @MiddleMouseButton => m_Wrapper.m_MapEditor_MiddleMouseButton;
        public InputActionMap Get() { return m_Wrapper.m_MapEditor; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MapEditorActions set) { return set.Get(); }
        public void SetCallbacks(IMapEditorActions instance)
        {
            if (m_Wrapper.m_MapEditorActionsCallbackInterface != null)
            {
                @MousePosition.started -= m_Wrapper.m_MapEditorActionsCallbackInterface.OnMousePosition;
                @MousePosition.performed -= m_Wrapper.m_MapEditorActionsCallbackInterface.OnMousePosition;
                @MousePosition.canceled -= m_Wrapper.m_MapEditorActionsCallbackInterface.OnMousePosition;
                @LeftMouseButton.started -= m_Wrapper.m_MapEditorActionsCallbackInterface.OnLeftMouseButton;
                @LeftMouseButton.performed -= m_Wrapper.m_MapEditorActionsCallbackInterface.OnLeftMouseButton;
                @LeftMouseButton.canceled -= m_Wrapper.m_MapEditorActionsCallbackInterface.OnLeftMouseButton;
                @LeftMouseButtonHold.started -= m_Wrapper.m_MapEditorActionsCallbackInterface.OnLeftMouseButtonHold;
                @LeftMouseButtonHold.performed -= m_Wrapper.m_MapEditorActionsCallbackInterface.OnLeftMouseButtonHold;
                @LeftMouseButtonHold.canceled -= m_Wrapper.m_MapEditorActionsCallbackInterface.OnLeftMouseButtonHold;
                @RightMouseButton.started -= m_Wrapper.m_MapEditorActionsCallbackInterface.OnRightMouseButton;
                @RightMouseButton.performed -= m_Wrapper.m_MapEditorActionsCallbackInterface.OnRightMouseButton;
                @RightMouseButton.canceled -= m_Wrapper.m_MapEditorActionsCallbackInterface.OnRightMouseButton;
                @MiddleMouseButton.started -= m_Wrapper.m_MapEditorActionsCallbackInterface.OnMiddleMouseButton;
                @MiddleMouseButton.performed -= m_Wrapper.m_MapEditorActionsCallbackInterface.OnMiddleMouseButton;
                @MiddleMouseButton.canceled -= m_Wrapper.m_MapEditorActionsCallbackInterface.OnMiddleMouseButton;
            }
            m_Wrapper.m_MapEditorActionsCallbackInterface = instance;
            if (instance != null)
            {
                @MousePosition.started += instance.OnMousePosition;
                @MousePosition.performed += instance.OnMousePosition;
                @MousePosition.canceled += instance.OnMousePosition;
                @LeftMouseButton.started += instance.OnLeftMouseButton;
                @LeftMouseButton.performed += instance.OnLeftMouseButton;
                @LeftMouseButton.canceled += instance.OnLeftMouseButton;
                @LeftMouseButtonHold.started += instance.OnLeftMouseButtonHold;
                @LeftMouseButtonHold.performed += instance.OnLeftMouseButtonHold;
                @LeftMouseButtonHold.canceled += instance.OnLeftMouseButtonHold;
                @RightMouseButton.started += instance.OnRightMouseButton;
                @RightMouseButton.performed += instance.OnRightMouseButton;
                @RightMouseButton.canceled += instance.OnRightMouseButton;
                @MiddleMouseButton.started += instance.OnMiddleMouseButton;
                @MiddleMouseButton.performed += instance.OnMiddleMouseButton;
                @MiddleMouseButton.canceled += instance.OnMiddleMouseButton;
            }
        }
    }
    public MapEditorActions @MapEditor => new MapEditorActions(this);
    public interface IMapEditorActions
    {
        void OnMousePosition(InputAction.CallbackContext context);
        void OnLeftMouseButton(InputAction.CallbackContext context);
        void OnLeftMouseButtonHold(InputAction.CallbackContext context);
        void OnRightMouseButton(InputAction.CallbackContext context);
        void OnMiddleMouseButton(InputAction.CallbackContext context);
    }
}
