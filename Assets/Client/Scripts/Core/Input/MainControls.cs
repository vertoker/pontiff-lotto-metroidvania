// GENERATED AUTOMATICALLY FROM 'Assets/Data/MainControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace Core.Input
{
    public class @MainControls : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @MainControls()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""MainControls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""95482df4-8f4f-471f-9e0a-b66ebf33ac49"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""f4507f85-ec03-4c0f-bf19-38f83e99c4f8"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Action"",
                    ""type"": ""Button"",
                    ""id"": ""8029b513-fecf-4fb4-a51e-3f8b96f7c741"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""75d06ae4-b4a3-4089-be85-371979bbb6d0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""Button"",
                    ""id"": ""ae1eac79-c594-4ba3-931f-b263f0033be7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""FastAttack"",
                    ""type"": ""Button"",
                    ""id"": ""805f0ac5-039f-4478-8afa-e5371ef2072d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""StrongAttack"",
                    ""type"": ""Button"",
                    ""id"": ""03c9f202-7686-4937-bd15-ec80a35d2a44"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Block"",
                    ""type"": ""Button"",
                    ""id"": ""0127b4c9-3327-4104-9ba4-d2d26345bc6e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Weapon 0"",
                    ""type"": ""Button"",
                    ""id"": ""b5eaa313-a53a-4dc8-84bf-a769230b9c44"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Weapon 1"",
                    ""type"": ""Button"",
                    ""id"": ""cf33fcc5-b8c4-4415-9de6-f9243c359f38"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Weapon 2"",
                    ""type"": ""Button"",
                    ""id"": ""287ae1f5-4e8d-43b5-bee2-bfea21ba0efc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Weapon 3"",
                    ""type"": ""Button"",
                    ""id"": ""6b6140ea-d9c3-4baf-a40b-c960c5df8897"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Weapon 4"",
                    ""type"": ""Button"",
                    ""id"": ""c4f27836-3e73-4ef2-97fa-352b5d4d7eff"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Weapon 5"",
                    ""type"": ""Button"",
                    ""id"": ""f0c86d8e-6253-4907-8274-46dae1153791"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7dc9faa1-2ff0-4677-a18b-2a781229cd6b"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Main"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""516bf376-3671-4b39-bf34-3ec4944d8881"",
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
                    ""id"": ""2cc6fc4b-1dd2-48ed-aa84-42b3f2e63b0c"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Main"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""e76cae6c-e279-47d7-9b0f-3514c55eb972"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Main"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""4ddb1118-1f1f-4577-9c93-375e1dca7664"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Main"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""b542d6fc-bd66-4ec5-85af-b5b6aaf59e49"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Main"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard 2"",
                    ""id"": ""aa15f7e1-d640-4841-a65d-31ef7914dbd2"",
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
                    ""id"": ""34a515fd-cf62-423e-956d-9ea2ec68ab1d"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Main"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""153ac74f-dc33-442e-add9-b2e6437009df"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Main"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""0ca11333-569b-449a-9cb1-8f65bce41978"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Main"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ca70320f-dad0-4ccd-9c30-7d2aa15e3190"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Main"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""d9d776f8-1638-4549-8ada-0af59d5b84c8"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Main"",
                    ""action"": ""Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d76397b8-b7e2-4864-a46e-36335cfa267b"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Main"",
                    ""action"": ""Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cd48ddec-203c-49eb-b25b-05390b171b94"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Main"",
                    ""action"": ""Action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d852bcec-295b-421f-82da-b2b8d708bf1e"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Main"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""76dbd33b-0d81-4b45-aa15-7a8a11b69148"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Main"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0ab88f5b-aef9-429f-ae95-5274f0910b80"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Main"",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0f210378-f110-4a20-8cfb-f69639b9efd3"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Main"",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""927627f3-4bea-4dc6-a203-a26b792e7443"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Main"",
                    ""action"": ""FastAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f83f338b-25d1-458d-960a-6474ce07fe7e"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Main"",
                    ""action"": ""FastAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""db38cb3a-2875-48b8-9083-b75957ff91b9"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Main"",
                    ""action"": ""StrongAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b8e9aee3-5c28-4e9a-9fcf-2644dbf9104f"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Main"",
                    ""action"": ""StrongAttack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a36aadd0-54ef-4c26-849b-4687463cb16f"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Main"",
                    ""action"": ""Block"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""02a875f0-13a1-4ef5-b05f-3e8d91349f78"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Main"",
                    ""action"": ""Block"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c148e053-46ee-450f-8985-e60f31018b32"",
                    ""path"": ""<Keyboard>/0"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Main"",
                    ""action"": ""Weapon 0"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ab5c565d-b56e-486a-a2ea-d88f5c5baaf4"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Main"",
                    ""action"": ""Weapon 0"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""148ba216-d122-49fc-8fe8-070f29832618"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Main"",
                    ""action"": ""Weapon 1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5d5dfabb-58cb-4c7c-b7f0-f2ecd603335c"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Main"",
                    ""action"": ""Weapon 1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7dfb2811-34a8-43fe-8d3f-8527c36555fe"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Main"",
                    ""action"": ""Weapon 2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""220ca727-17a6-4fd9-afce-b6469dee9780"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Main"",
                    ""action"": ""Weapon 2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d34899ac-aed8-4b4e-a1f6-25de1a4cbab5"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Main"",
                    ""action"": ""Weapon 3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9fda8585-b09e-496e-b68f-2d2e1aa6a149"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Main"",
                    ""action"": ""Weapon 3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""21e81abf-eeb7-459b-b1f0-73c9f3c79fce"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Main"",
                    ""action"": ""Weapon 4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""90d097c2-385b-42e8-aedd-496cdcf14d1e"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Main"",
                    ""action"": ""Weapon 4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""332d3700-3386-4e5f-ba15-7bd73401b9bb"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Main"",
                    ""action"": ""Weapon 5"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5ede511e-2030-477d-bc0c-453b1997e78e"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Main"",
                    ""action"": ""Weapon 5"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Main"",
            ""bindingGroup"": ""Main"",
            ""devices"": []
        }
    ]
}");
            // Player
            m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
            m_Player_Movement = m_Player.FindAction("Movement", throwIfNotFound: true);
            m_Player_Action = m_Player.FindAction("Action", throwIfNotFound: true);
            m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
            m_Player_Dash = m_Player.FindAction("Dash", throwIfNotFound: true);
            m_Player_FastAttack = m_Player.FindAction("FastAttack", throwIfNotFound: true);
            m_Player_StrongAttack = m_Player.FindAction("StrongAttack", throwIfNotFound: true);
            m_Player_Block = m_Player.FindAction("Block", throwIfNotFound: true);
            m_Player_Weapon0 = m_Player.FindAction("Weapon 0", throwIfNotFound: true);
            m_Player_Weapon1 = m_Player.FindAction("Weapon 1", throwIfNotFound: true);
            m_Player_Weapon2 = m_Player.FindAction("Weapon 2", throwIfNotFound: true);
            m_Player_Weapon3 = m_Player.FindAction("Weapon 3", throwIfNotFound: true);
            m_Player_Weapon4 = m_Player.FindAction("Weapon 4", throwIfNotFound: true);
            m_Player_Weapon5 = m_Player.FindAction("Weapon 5", throwIfNotFound: true);
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

        // Player
        private readonly InputActionMap m_Player;
        private IPlayerActions m_PlayerActionsCallbackInterface;
        private readonly InputAction m_Player_Movement;
        private readonly InputAction m_Player_Action;
        private readonly InputAction m_Player_Jump;
        private readonly InputAction m_Player_Dash;
        private readonly InputAction m_Player_FastAttack;
        private readonly InputAction m_Player_StrongAttack;
        private readonly InputAction m_Player_Block;
        private readonly InputAction m_Player_Weapon0;
        private readonly InputAction m_Player_Weapon1;
        private readonly InputAction m_Player_Weapon2;
        private readonly InputAction m_Player_Weapon3;
        private readonly InputAction m_Player_Weapon4;
        private readonly InputAction m_Player_Weapon5;
        public struct PlayerActions
        {
            private @MainControls m_Wrapper;
            public PlayerActions(@MainControls wrapper) { m_Wrapper = wrapper; }
            public InputAction @Movement => m_Wrapper.m_Player_Movement;
            public InputAction @Action => m_Wrapper.m_Player_Action;
            public InputAction @Jump => m_Wrapper.m_Player_Jump;
            public InputAction @Dash => m_Wrapper.m_Player_Dash;
            public InputAction @FastAttack => m_Wrapper.m_Player_FastAttack;
            public InputAction @StrongAttack => m_Wrapper.m_Player_StrongAttack;
            public InputAction @Block => m_Wrapper.m_Player_Block;
            public InputAction @Weapon0 => m_Wrapper.m_Player_Weapon0;
            public InputAction @Weapon1 => m_Wrapper.m_Player_Weapon1;
            public InputAction @Weapon2 => m_Wrapper.m_Player_Weapon2;
            public InputAction @Weapon3 => m_Wrapper.m_Player_Weapon3;
            public InputAction @Weapon4 => m_Wrapper.m_Player_Weapon4;
            public InputAction @Weapon5 => m_Wrapper.m_Player_Weapon5;
            public InputActionMap Get() { return m_Wrapper.m_Player; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
            public void SetCallbacks(IPlayerActions instance)
            {
                if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
                {
                    @Movement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                    @Movement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                    @Movement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                    @Action.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAction;
                    @Action.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAction;
                    @Action.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnAction;
                    @Jump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                    @Jump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                    @Jump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                    @Dash.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDash;
                    @Dash.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDash;
                    @Dash.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnDash;
                    @FastAttack.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFastAttack;
                    @FastAttack.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFastAttack;
                    @FastAttack.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnFastAttack;
                    @StrongAttack.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStrongAttack;
                    @StrongAttack.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStrongAttack;
                    @StrongAttack.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnStrongAttack;
                    @Block.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBlock;
                    @Block.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBlock;
                    @Block.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnBlock;
                    @Weapon0.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWeapon0;
                    @Weapon0.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWeapon0;
                    @Weapon0.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWeapon0;
                    @Weapon1.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWeapon1;
                    @Weapon1.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWeapon1;
                    @Weapon1.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWeapon1;
                    @Weapon2.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWeapon2;
                    @Weapon2.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWeapon2;
                    @Weapon2.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWeapon2;
                    @Weapon3.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWeapon3;
                    @Weapon3.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWeapon3;
                    @Weapon3.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWeapon3;
                    @Weapon4.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWeapon4;
                    @Weapon4.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWeapon4;
                    @Weapon4.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWeapon4;
                    @Weapon5.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWeapon5;
                    @Weapon5.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWeapon5;
                    @Weapon5.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnWeapon5;
                }
                m_Wrapper.m_PlayerActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Movement.started += instance.OnMovement;
                    @Movement.performed += instance.OnMovement;
                    @Movement.canceled += instance.OnMovement;
                    @Action.started += instance.OnAction;
                    @Action.performed += instance.OnAction;
                    @Action.canceled += instance.OnAction;
                    @Jump.started += instance.OnJump;
                    @Jump.performed += instance.OnJump;
                    @Jump.canceled += instance.OnJump;
                    @Dash.started += instance.OnDash;
                    @Dash.performed += instance.OnDash;
                    @Dash.canceled += instance.OnDash;
                    @FastAttack.started += instance.OnFastAttack;
                    @FastAttack.performed += instance.OnFastAttack;
                    @FastAttack.canceled += instance.OnFastAttack;
                    @StrongAttack.started += instance.OnStrongAttack;
                    @StrongAttack.performed += instance.OnStrongAttack;
                    @StrongAttack.canceled += instance.OnStrongAttack;
                    @Block.started += instance.OnBlock;
                    @Block.performed += instance.OnBlock;
                    @Block.canceled += instance.OnBlock;
                    @Weapon0.started += instance.OnWeapon0;
                    @Weapon0.performed += instance.OnWeapon0;
                    @Weapon0.canceled += instance.OnWeapon0;
                    @Weapon1.started += instance.OnWeapon1;
                    @Weapon1.performed += instance.OnWeapon1;
                    @Weapon1.canceled += instance.OnWeapon1;
                    @Weapon2.started += instance.OnWeapon2;
                    @Weapon2.performed += instance.OnWeapon2;
                    @Weapon2.canceled += instance.OnWeapon2;
                    @Weapon3.started += instance.OnWeapon3;
                    @Weapon3.performed += instance.OnWeapon3;
                    @Weapon3.canceled += instance.OnWeapon3;
                    @Weapon4.started += instance.OnWeapon4;
                    @Weapon4.performed += instance.OnWeapon4;
                    @Weapon4.canceled += instance.OnWeapon4;
                    @Weapon5.started += instance.OnWeapon5;
                    @Weapon5.performed += instance.OnWeapon5;
                    @Weapon5.canceled += instance.OnWeapon5;
                }
            }
        }
        public PlayerActions @Player => new PlayerActions(this);
        private int m_MainSchemeIndex = -1;
        public InputControlScheme MainScheme
        {
            get
            {
                if (m_MainSchemeIndex == -1) m_MainSchemeIndex = asset.FindControlSchemeIndex("Main");
                return asset.controlSchemes[m_MainSchemeIndex];
            }
        }
        public interface IPlayerActions
        {
            void OnMovement(InputAction.CallbackContext context);
            void OnAction(InputAction.CallbackContext context);
            void OnJump(InputAction.CallbackContext context);
            void OnDash(InputAction.CallbackContext context);
            void OnFastAttack(InputAction.CallbackContext context);
            void OnStrongAttack(InputAction.CallbackContext context);
            void OnBlock(InputAction.CallbackContext context);
            void OnWeapon0(InputAction.CallbackContext context);
            void OnWeapon1(InputAction.CallbackContext context);
            void OnWeapon2(InputAction.CallbackContext context);
            void OnWeapon3(InputAction.CallbackContext context);
            void OnWeapon4(InputAction.CallbackContext context);
            void OnWeapon5(InputAction.CallbackContext context);
        }
    }
}
