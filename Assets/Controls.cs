//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.8.2
//     from Assets/Controls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;
using UnityEngine;

public partial class @Controls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @Controls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Controls"",
    ""maps"": [
        {
            ""name"": ""PlayerNormal"",
            ""id"": ""6f9caae7-9e91-4fbc-9273-8db37fb69809"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Value"",
                    ""id"": ""fbc09548-5cfb-40a5-b042-be86e49072df"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""MoveHorizontal"",
                    ""type"": ""Button"",
                    ""id"": ""05228187-945a-4fab-bd65-41ef77231cda"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MoveVertical"",
                    ""type"": ""Button"",
                    ""id"": ""72c15f31-c26d-465f-9825-3b67b61748ad"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""61bf4093-3b65-44f6-85cb-00a49457815f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SpecialAttack"",
                    ""type"": ""Button"",
                    ""id"": ""448e0d7f-5452-4c7e-9e40-4b1c75ffaf88"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4659e850-150f-4bd1-bbcf-075d3d413723"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""00aa0ea9-9401-49d7-9c16-96f76e229db1"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""f0faced4-aaa6-452d-a376-c36dca3b0107"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveHorizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""a1a34773-f853-4ffb-a4fa-99720666b56d"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""MoveHorizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""9ec41bae-f947-4ebe-a7c3-35b548d46aa6"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""MoveHorizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis Gamepad"",
                    ""id"": ""e1e76ff0-6b4f-4754-920d-ffa5c0fa5797"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": ""AxisDeadzone(min=0.3,max=0.3)"",
                    ""groups"": """",
                    ""action"": ""MoveHorizontal"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""f3923744-04cf-4f76-a5fb-9fbe69064d24"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""MoveHorizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""3f05740a-f4a6-4dc6-b320-00873637a2d8"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""MoveHorizontal"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis Vertical"",
                    ""id"": ""2bd4d098-b3ae-441e-b8d9-379a8c47ae91"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveVertical"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""8a0196e3-8ccf-478d-979e-6d9b5d0ddd81"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""MoveVertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""70a7c054-7c3c-4a32-90b6-225be68e9c0f"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""MoveVertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""1D Axis Gamepad"",
                    ""id"": ""5eab7fa2-10bc-4338-9af7-65dea1924d5f"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveVertical"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""c1e72fbf-b975-4bd1-a450-5bf5e1123d70"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""MoveVertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""414edf13-be67-4aff-9c85-9bb452a4f002"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""MoveVertical"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""8321a061-301a-469c-9449-027b8c6beecf"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""263aabdd-b897-4e30-b719-232f8e198f95"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""One Modifier"",
                    ""id"": ""b2c4a4e9-c029-400e-b6db-f74f36bcd2b8"",
                    ""path"": ""OneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SpecialAttack"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""05d61981-0291-444e-b45d-c79371b021ef"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""SpecialAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""binding"",
                    ""id"": ""f4e9ff95-547d-4b3c-9483-b81643e28088"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardMouse"",
                    ""action"": ""SpecialAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""One Modifier Gamepad"",
                    ""id"": ""60a9d4b1-54c7-4afe-9769-11db2d5059df"",
                    ""path"": ""OneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SpecialAttack"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""12a4c8c1-344a-49d8-9b6d-0b6e50dd2d34"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""SpecialAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""binding"",
                    ""id"": ""b9128865-2441-4fab-bc3a-aad839b8674b"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""SpecialAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""PlayerInCar"",
            ""id"": ""f64ecefe-052f-4804-9597-c32c7735728c"",
            ""actions"": [
                {
                    ""name"": ""Accelerate"",
                    ""type"": ""Button"",
                    ""id"": ""00ac8ccf-b5aa-4f03-9957-3490cc4039f6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Brake"",
                    ""type"": ""Button"",
                    ""id"": ""d76759fa-fd58-41f5-840f-3d036cd1331a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Klaxon"",
                    ""type"": ""Button"",
                    ""id"": ""21a74ef8-3291-4946-b7ab-8b6c56671c72"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7d7cf7c5-5e98-4c5e-a838-1006bb8b796c"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Accelerate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""314bd1b9-845a-4c88-b221-c137b0801837"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Brake"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8b2f97a0-9310-409e-8ae6-e45d4898b146"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Klaxon"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""PlayerInWater"",
            ""id"": ""7b48861e-bafa-4a44-be21-17d67233af9c"",
            ""actions"": [
                {
                    ""name"": ""Swim"",
                    ""type"": ""Button"",
                    ""id"": ""22ee25f2-0f8f-4c51-8f9c-e080bb80c9d4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Dive"",
                    ""type"": ""Button"",
                    ""id"": ""1ded1ccc-7352-48cf-b427-c1b2a0cfc4b8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Emerge"",
                    ""type"": ""Button"",
                    ""id"": ""aa50f52e-e09d-446c-bc10-db665bddd51d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""aee497c9-eccf-49c9-85d9-3992bf18d000"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Swim"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""478953de-fb4b-469d-8309-14bc0465e735"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dive"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""897a8599-b2c6-4b3d-a841-f1b3e648baa6"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Emerge"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""KeyboardMouse"",
            ""bindingGroup"": ""KeyboardMouse"",
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
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // PlayerNormal
        m_PlayerNormal = asset.FindActionMap("PlayerNormal", throwIfNotFound: true);
        m_PlayerNormal_Jump = m_PlayerNormal.FindAction("Jump", throwIfNotFound: true);
        m_PlayerNormal_MoveHorizontal = m_PlayerNormal.FindAction("MoveHorizontal", throwIfNotFound: true);
        m_PlayerNormal_MoveVertical = m_PlayerNormal.FindAction("MoveVertical", throwIfNotFound: true);
        m_PlayerNormal_Attack = m_PlayerNormal.FindAction("Attack", throwIfNotFound: true);
        m_PlayerNormal_SpecialAttack = m_PlayerNormal.FindAction("SpecialAttack", throwIfNotFound: true);
        // PlayerInCar
        m_PlayerInCar = asset.FindActionMap("PlayerInCar", throwIfNotFound: true);
        m_PlayerInCar_Accelerate = m_PlayerInCar.FindAction("Accelerate", throwIfNotFound: true);
        m_PlayerInCar_Brake = m_PlayerInCar.FindAction("Brake", throwIfNotFound: true);
        m_PlayerInCar_Klaxon = m_PlayerInCar.FindAction("Klaxon", throwIfNotFound: true);
        // PlayerInWater
        m_PlayerInWater = asset.FindActionMap("PlayerInWater", throwIfNotFound: true);
        m_PlayerInWater_Swim = m_PlayerInWater.FindAction("Swim", throwIfNotFound: true);
        m_PlayerInWater_Dive = m_PlayerInWater.FindAction("Dive", throwIfNotFound: true);
        m_PlayerInWater_Emerge = m_PlayerInWater.FindAction("Emerge", throwIfNotFound: true);
    }

    ~@Controls()
    {
        Debug.Assert(!m_PlayerNormal.enabled, "This will cause a leak and performance issues, Controls.PlayerNormal.Disable() has not been called.");
        Debug.Assert(!m_PlayerInCar.enabled, "This will cause a leak and performance issues, Controls.PlayerInCar.Disable() has not been called.");
        Debug.Assert(!m_PlayerInWater.enabled, "This will cause a leak and performance issues, Controls.PlayerInWater.Disable() has not been called.");
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

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // PlayerNormal
    private readonly InputActionMap m_PlayerNormal;
    private List<IPlayerNormalActions> m_PlayerNormalActionsCallbackInterfaces = new List<IPlayerNormalActions>();
    private readonly InputAction m_PlayerNormal_Jump;
    private readonly InputAction m_PlayerNormal_MoveHorizontal;
    private readonly InputAction m_PlayerNormal_MoveVertical;
    private readonly InputAction m_PlayerNormal_Attack;
    private readonly InputAction m_PlayerNormal_SpecialAttack;
    public struct PlayerNormalActions
    {
        private @Controls m_Wrapper;
        public PlayerNormalActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_PlayerNormal_Jump;
        public InputAction @MoveHorizontal => m_Wrapper.m_PlayerNormal_MoveHorizontal;
        public InputAction @MoveVertical => m_Wrapper.m_PlayerNormal_MoveVertical;
        public InputAction @Attack => m_Wrapper.m_PlayerNormal_Attack;
        public InputAction @SpecialAttack => m_Wrapper.m_PlayerNormal_SpecialAttack;
        public InputActionMap Get() { return m_Wrapper.m_PlayerNormal; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerNormalActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerNormalActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerNormalActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerNormalActionsCallbackInterfaces.Add(instance);
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
            @MoveHorizontal.started += instance.OnMoveHorizontal;
            @MoveHorizontal.performed += instance.OnMoveHorizontal;
            @MoveHorizontal.canceled += instance.OnMoveHorizontal;
            @MoveVertical.started += instance.OnMoveVertical;
            @MoveVertical.performed += instance.OnMoveVertical;
            @MoveVertical.canceled += instance.OnMoveVertical;
            @Attack.started += instance.OnAttack;
            @Attack.performed += instance.OnAttack;
            @Attack.canceled += instance.OnAttack;
            @SpecialAttack.started += instance.OnSpecialAttack;
            @SpecialAttack.performed += instance.OnSpecialAttack;
            @SpecialAttack.canceled += instance.OnSpecialAttack;
        }

        private void UnregisterCallbacks(IPlayerNormalActions instance)
        {
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
            @MoveHorizontal.started -= instance.OnMoveHorizontal;
            @MoveHorizontal.performed -= instance.OnMoveHorizontal;
            @MoveHorizontal.canceled -= instance.OnMoveHorizontal;
            @MoveVertical.started -= instance.OnMoveVertical;
            @MoveVertical.performed -= instance.OnMoveVertical;
            @MoveVertical.canceled -= instance.OnMoveVertical;
            @Attack.started -= instance.OnAttack;
            @Attack.performed -= instance.OnAttack;
            @Attack.canceled -= instance.OnAttack;
            @SpecialAttack.started -= instance.OnSpecialAttack;
            @SpecialAttack.performed -= instance.OnSpecialAttack;
            @SpecialAttack.canceled -= instance.OnSpecialAttack;
        }

        public void RemoveCallbacks(IPlayerNormalActions instance)
        {
            if (m_Wrapper.m_PlayerNormalActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerNormalActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerNormalActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerNormalActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerNormalActions @PlayerNormal => new PlayerNormalActions(this);

    // PlayerInCar
    private readonly InputActionMap m_PlayerInCar;
    private List<IPlayerInCarActions> m_PlayerInCarActionsCallbackInterfaces = new List<IPlayerInCarActions>();
    private readonly InputAction m_PlayerInCar_Accelerate;
    private readonly InputAction m_PlayerInCar_Brake;
    private readonly InputAction m_PlayerInCar_Klaxon;
    public struct PlayerInCarActions
    {
        private @Controls m_Wrapper;
        public PlayerInCarActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Accelerate => m_Wrapper.m_PlayerInCar_Accelerate;
        public InputAction @Brake => m_Wrapper.m_PlayerInCar_Brake;
        public InputAction @Klaxon => m_Wrapper.m_PlayerInCar_Klaxon;
        public InputActionMap Get() { return m_Wrapper.m_PlayerInCar; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerInCarActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerInCarActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerInCarActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerInCarActionsCallbackInterfaces.Add(instance);
            @Accelerate.started += instance.OnAccelerate;
            @Accelerate.performed += instance.OnAccelerate;
            @Accelerate.canceled += instance.OnAccelerate;
            @Brake.started += instance.OnBrake;
            @Brake.performed += instance.OnBrake;
            @Brake.canceled += instance.OnBrake;
            @Klaxon.started += instance.OnKlaxon;
            @Klaxon.performed += instance.OnKlaxon;
            @Klaxon.canceled += instance.OnKlaxon;
        }

        private void UnregisterCallbacks(IPlayerInCarActions instance)
        {
            @Accelerate.started -= instance.OnAccelerate;
            @Accelerate.performed -= instance.OnAccelerate;
            @Accelerate.canceled -= instance.OnAccelerate;
            @Brake.started -= instance.OnBrake;
            @Brake.performed -= instance.OnBrake;
            @Brake.canceled -= instance.OnBrake;
            @Klaxon.started -= instance.OnKlaxon;
            @Klaxon.performed -= instance.OnKlaxon;
            @Klaxon.canceled -= instance.OnKlaxon;
        }

        public void RemoveCallbacks(IPlayerInCarActions instance)
        {
            if (m_Wrapper.m_PlayerInCarActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerInCarActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerInCarActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerInCarActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerInCarActions @PlayerInCar => new PlayerInCarActions(this);

    // PlayerInWater
    private readonly InputActionMap m_PlayerInWater;
    private List<IPlayerInWaterActions> m_PlayerInWaterActionsCallbackInterfaces = new List<IPlayerInWaterActions>();
    private readonly InputAction m_PlayerInWater_Swim;
    private readonly InputAction m_PlayerInWater_Dive;
    private readonly InputAction m_PlayerInWater_Emerge;
    public struct PlayerInWaterActions
    {
        private @Controls m_Wrapper;
        public PlayerInWaterActions(@Controls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Swim => m_Wrapper.m_PlayerInWater_Swim;
        public InputAction @Dive => m_Wrapper.m_PlayerInWater_Dive;
        public InputAction @Emerge => m_Wrapper.m_PlayerInWater_Emerge;
        public InputActionMap Get() { return m_Wrapper.m_PlayerInWater; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerInWaterActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerInWaterActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerInWaterActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerInWaterActionsCallbackInterfaces.Add(instance);
            @Swim.started += instance.OnSwim;
            @Swim.performed += instance.OnSwim;
            @Swim.canceled += instance.OnSwim;
            @Dive.started += instance.OnDive;
            @Dive.performed += instance.OnDive;
            @Dive.canceled += instance.OnDive;
            @Emerge.started += instance.OnEmerge;
            @Emerge.performed += instance.OnEmerge;
            @Emerge.canceled += instance.OnEmerge;
        }

        private void UnregisterCallbacks(IPlayerInWaterActions instance)
        {
            @Swim.started -= instance.OnSwim;
            @Swim.performed -= instance.OnSwim;
            @Swim.canceled -= instance.OnSwim;
            @Dive.started -= instance.OnDive;
            @Dive.performed -= instance.OnDive;
            @Dive.canceled -= instance.OnDive;
            @Emerge.started -= instance.OnEmerge;
            @Emerge.performed -= instance.OnEmerge;
            @Emerge.canceled -= instance.OnEmerge;
        }

        public void RemoveCallbacks(IPlayerInWaterActions instance)
        {
            if (m_Wrapper.m_PlayerInWaterActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerInWaterActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerInWaterActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerInWaterActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerInWaterActions @PlayerInWater => new PlayerInWaterActions(this);
    private int m_KeyboardMouseSchemeIndex = -1;
    public InputControlScheme KeyboardMouseScheme
    {
        get
        {
            if (m_KeyboardMouseSchemeIndex == -1) m_KeyboardMouseSchemeIndex = asset.FindControlSchemeIndex("KeyboardMouse");
            return asset.controlSchemes[m_KeyboardMouseSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface IPlayerNormalActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnMoveHorizontal(InputAction.CallbackContext context);
        void OnMoveVertical(InputAction.CallbackContext context);
        void OnAttack(InputAction.CallbackContext context);
        void OnSpecialAttack(InputAction.CallbackContext context);
    }
    public interface IPlayerInCarActions
    {
        void OnAccelerate(InputAction.CallbackContext context);
        void OnBrake(InputAction.CallbackContext context);
        void OnKlaxon(InputAction.CallbackContext context);
    }
    public interface IPlayerInWaterActions
    {
        void OnSwim(InputAction.CallbackContext context);
        void OnDive(InputAction.CallbackContext context);
        void OnEmerge(InputAction.CallbackContext context);
    }
}