// GENERATED AUTOMATICALLY FROM 'Assets/InputActions/PlayerInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace Minecraft.InputActions
{
    public class @PlayerInput : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @PlayerInput()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInput"",
    ""maps"": [
        {
            ""name"": ""Movement"",
            ""id"": ""5983b4bd-cd68-4a9b-88f2-09b721509732"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""1215ed2a-b947-4ab2-aeda-2b42f6406993"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""f806a8de-0c81-4f2a-9b28-b8418992bf79"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""50461673-bd00-43e1-ac37-2d01715e4e8d"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""6bcaafb6-c0f7-4480-9b39-315cc691ea2e"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""3717f3ce-6794-446a-8f34-940eca0cb48f"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""29248be8-0f02-4342-a4bd-ce99d3da245a"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""2b507877-8c13-4c31-8819-44c5d4353af9"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""ArrowKeys"",
                    ""id"": ""b76b98d5-c5d8-4dbd-b760-eb71f32d3dd2"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""a36e2012-18a7-48cf-963e-b25aece15140"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""3bc599b2-eb40-4c1f-b11d-798ad97cb9da"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""661800ad-be83-4933-92da-9ec011b03e34"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""650116aa-13a1-44f9-aef7-34f007b3ed10"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardAndMouse"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""da0e8ba9-52bc-4b1d-b8cc-f6946941ec95"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Look"",
            ""id"": ""d14a36c1-f46e-4c42-b5e4-715b7b55b51e"",
            ""actions"": [
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""2f38caec-c65f-4e0f-af75-5f230cf5147b"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""3637fd3c-690b-4548-a144-398ceadb5efc"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""KeyboardAndMouse"",
            ""bindingGroup"": ""KeyboardAndMouse"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
            // Movement
            m_Movement = asset.FindActionMap("Movement", throwIfNotFound: true);
            m_Movement_Movement = m_Movement.FindAction("Movement", throwIfNotFound: true);
            m_Movement_Jump = m_Movement.FindAction("Jump", throwIfNotFound: true);
            // Look
            m_Look = asset.FindActionMap("Look", throwIfNotFound: true);
            m_Look_Look = m_Look.FindAction("Look", throwIfNotFound: true);
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

        // Movement
        private readonly InputActionMap m_Movement;
        private IMovementActions m_MovementActionsCallbackInterface;
        private readonly InputAction m_Movement_Movement;
        private readonly InputAction m_Movement_Jump;
        public struct MovementActions
        {
            private @PlayerInput m_Wrapper;
            public MovementActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
            public InputAction @Movement => m_Wrapper.m_Movement_Movement;
            public InputAction @Jump => m_Wrapper.m_Movement_Jump;
            public InputActionMap Get() { return m_Wrapper.m_Movement; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(MovementActions set) { return set.Get(); }
            public void SetCallbacks(IMovementActions instance)
            {
                if (m_Wrapper.m_MovementActionsCallbackInterface != null)
                {
                    @Movement.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnMovement;
                    @Movement.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnMovement;
                    @Movement.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnMovement;
                    @Jump.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnJump;
                    @Jump.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnJump;
                    @Jump.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnJump;
                }
                m_Wrapper.m_MovementActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Movement.started += instance.OnMovement;
                    @Movement.performed += instance.OnMovement;
                    @Movement.canceled += instance.OnMovement;
                    @Jump.started += instance.OnJump;
                    @Jump.performed += instance.OnJump;
                    @Jump.canceled += instance.OnJump;
                }
            }
        }
        public MovementActions @Movement => new MovementActions(this);

        // Look
        private readonly InputActionMap m_Look;
        private ILookActions m_LookActionsCallbackInterface;
        private readonly InputAction m_Look_Look;
        public struct LookActions
        {
            private @PlayerInput m_Wrapper;
            public LookActions(@PlayerInput wrapper) { m_Wrapper = wrapper; }
            public InputAction @Look => m_Wrapper.m_Look_Look;
            public InputActionMap Get() { return m_Wrapper.m_Look; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(LookActions set) { return set.Get(); }
            public void SetCallbacks(ILookActions instance)
            {
                if (m_Wrapper.m_LookActionsCallbackInterface != null)
                {
                    @Look.started -= m_Wrapper.m_LookActionsCallbackInterface.OnLook;
                    @Look.performed -= m_Wrapper.m_LookActionsCallbackInterface.OnLook;
                    @Look.canceled -= m_Wrapper.m_LookActionsCallbackInterface.OnLook;
                }
                m_Wrapper.m_LookActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Look.started += instance.OnLook;
                    @Look.performed += instance.OnLook;
                    @Look.canceled += instance.OnLook;
                }
            }
        }
        public LookActions @Look => new LookActions(this);
        private int m_KeyboardAndMouseSchemeIndex = -1;
        public InputControlScheme KeyboardAndMouseScheme
        {
            get
            {
                if (m_KeyboardAndMouseSchemeIndex == -1) m_KeyboardAndMouseSchemeIndex = asset.FindControlSchemeIndex("KeyboardAndMouse");
                return asset.controlSchemes[m_KeyboardAndMouseSchemeIndex];
            }
        }
        public interface IMovementActions
        {
            void OnMovement(InputAction.CallbackContext context);
            void OnJump(InputAction.CallbackContext context);
        }
        public interface ILookActions
        {
            void OnLook(InputAction.CallbackContext context);
        }
    }
}
