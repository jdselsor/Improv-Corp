// GENERATED AUTOMATICALLY FROM 'Assets/Inputs/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace Input
{
    public class @PlayerControls : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @PlayerControls()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""03eea018-0742-487f-9c8a-9028d5ca1c0d"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""7851cc71-b590-4387-b01a-cb949a1d3e29"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Crouch"",
                    ""type"": ""Button"",
                    ""id"": ""3d17ab4c-2529-487f-8288-9c8df9f7df96"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""1662cd23-4059-478b-a41d-2d0c48aeca0e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Open_Phone"",
                    ""type"": ""Button"",
                    ""id"": ""0845a619-b388-4299-80a8-095f06750707"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Movement"",
                    ""type"": ""Button"",
                    ""id"": ""9e1f4c1b-de61-4f5a-b9a1-21108d7d629b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause_Menu"",
                    ""type"": ""Button"",
                    ""id"": ""d9286c43-d377-4de8-ac71-9b983dfe9538"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Debug_Respawn"",
                    ""type"": ""Button"",
                    ""id"": ""ac15a509-4307-462f-97c7-2f885bbba25d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""e6aca7b8-a9ce-4eda-96ca-214712f26521"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Debug_Damage"",
                    ""type"": ""Button"",
                    ""id"": ""4229b902-cee5-4935-944e-427fb02f04dc"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Debug_Full_Ammo"",
                    ""type"": ""Button"",
                    ""id"": ""e4635236-ee1e-4d42-a306-36f295e83089"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Use_Ability_1"",
                    ""type"": ""Button"",
                    ""id"": ""e1a485a4-8c47-4bc2-b393-f9fbd978d3ae"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Use_Ability_2"",
                    ""type"": ""Button"",
                    ""id"": ""ea7384f6-19d6-435f-ab39-9888e544c4f9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Use_Ability_3"",
                    ""type"": ""Button"",
                    ""id"": ""ecba86c0-99aa-4ff7-8a04-3aa74e4bbdc8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Use_Ability_4"",
                    ""type"": ""Button"",
                    ""id"": ""53ea368f-e63b-4456-95f9-ff2d78bb7957"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7fe96725-9dd3-4e87-abce-473e156b0bb9"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""336aafa8-ef6e-4bf8-af26-d54a3c42cea0"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d57b612f-57b1-499d-ac16-cfac55de6f6c"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d0e4c2e3-528c-4137-bfce-886affdc0548"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Crouch"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9270d251-415e-421a-b5ef-e1f6d3858d25"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3cff5eab-0a01-4796-8ef0-71d40bf77211"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""75b0f3b5-4e49-49e9-9beb-f68ab4113f51"",
                    ""path"": ""<Keyboard>/i"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Open_Phone"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f66c28ce-3d39-47a2-9c84-e5453be68279"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Open_Phone"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9f169b22-3d4a-4023-9bc6-c44caf76b1ed"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause_Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""328c51ea-88c5-4b56-9080-35c46d99122a"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause_Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""47791a9f-9714-4d87-8ab5-5cf81df6b68c"",
                    ""path"": ""<Keyboard>/f1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Debug_Respawn"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Keyboard Movement"",
                    ""id"": ""0ff3f2d7-61a3-45f7-bdf4-000524c92791"",
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
                    ""id"": ""9ec9607e-05e8-42ed-a7dd-b6f890a5fded"",
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
                    ""id"": ""38728c3d-2a89-41cf-945e-25f1d8bfd959"",
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
                    ""id"": ""f60a7b2b-89bc-4087-982c-7b34aa8e2598"",
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
                    ""id"": ""dd52a482-1806-41ce-ba07-a3d3095c1403"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Gamepad Movement"",
                    ""id"": ""af0f4d09-3d02-445d-8426-c6e7168d263a"",
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
                    ""id"": ""44eeb497-0c76-472c-9577-f43aeb0bb052"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d9f2f72a-a3b6-43c7-9401-72827ad4740a"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""47665ca1-882f-48ee-aad2-48b579f0083d"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""93122c0e-5e0e-47b4-ad65-28ae0f9404cb"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""5e1cd68b-c7a1-404e-884d-43b32c0248b8"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""93219a39-da75-49aa-95f5-5eaf7f0a7225"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0c496285-4c06-46a5-8eb7-1697f9628847"",
                    ""path"": ""<Keyboard>/f2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Debug_Damage"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""db015790-a9ab-4b34-a1f6-6037a58b7770"",
                    ""path"": ""<Keyboard>/f3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Debug_Full_Ammo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1ad56993-9802-457c-b599-26ac9f41c0b1"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Use_Ability_1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eb712440-8453-4288-9a05-8e124e3d882c"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Use_Ability_2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""43fef5e2-f341-49e7-a676-92b5d32ab8ec"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Use_Ability_3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""12fc3ade-9530-477f-bf48-09edc957570d"",
                    ""path"": ""<Keyboard>/4"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Use_Ability_4"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Phone_Menu"",
            ""id"": ""91a76bcf-409a-4758-9c52-265cdd38999b"",
            ""actions"": [
                {
                    ""name"": ""Close"",
                    ""type"": ""Button"",
                    ""id"": ""e5f24d09-efe2-4967-a756-a8ee35347449"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Activate"",
                    ""type"": ""Button"",
                    ""id"": ""93d79be8-1487-4a59-9f8f-48f1f842c4f9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""df95ff64-f560-49b8-a4a5-dd8fd940ae4e"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Close"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4b22a22b-f7af-4bb8-b5cd-252d4d741915"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Close"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e74d7d64-ced0-4f03-8b7c-e18d96981dc3"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Activate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""76c4e37b-d650-4439-aa82-4105c12f1f5e"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Activate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Dialogue_Menu"",
            ""id"": ""dfe6cea1-77f7-44b3-bdc3-0b03cb90bcc2"",
            ""actions"": [
                {
                    ""name"": ""Procide_Dialogue"",
                    ""type"": ""Button"",
                    ""id"": ""7a1d2422-cdaa-4ea7-b41d-73ed2341f953"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""7c458660-c2c6-4d61-82a4-79f538e30e41"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Procide_Dialogue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""80889367-ce5f-4a75-a1df-bbecba93b4a5"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Procide_Dialogue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // Gameplay
            m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
            m_Gameplay_Jump = m_Gameplay.FindAction("Jump", throwIfNotFound: true);
            m_Gameplay_Crouch = m_Gameplay.FindAction("Crouch", throwIfNotFound: true);
            m_Gameplay_Interact = m_Gameplay.FindAction("Interact", throwIfNotFound: true);
            m_Gameplay_Open_Phone = m_Gameplay.FindAction("Open_Phone", throwIfNotFound: true);
            m_Gameplay_Movement = m_Gameplay.FindAction("Movement", throwIfNotFound: true);
            m_Gameplay_Pause_Menu = m_Gameplay.FindAction("Pause_Menu", throwIfNotFound: true);
            m_Gameplay_Debug_Respawn = m_Gameplay.FindAction("Debug_Respawn", throwIfNotFound: true);
            m_Gameplay_Attack = m_Gameplay.FindAction("Attack", throwIfNotFound: true);
            m_Gameplay_Debug_Damage = m_Gameplay.FindAction("Debug_Damage", throwIfNotFound: true);
            m_Gameplay_Debug_Full_Ammo = m_Gameplay.FindAction("Debug_Full_Ammo", throwIfNotFound: true);
            m_Gameplay_Use_Ability_1 = m_Gameplay.FindAction("Use_Ability_1", throwIfNotFound: true);
            m_Gameplay_Use_Ability_2 = m_Gameplay.FindAction("Use_Ability_2", throwIfNotFound: true);
            m_Gameplay_Use_Ability_3 = m_Gameplay.FindAction("Use_Ability_3", throwIfNotFound: true);
            m_Gameplay_Use_Ability_4 = m_Gameplay.FindAction("Use_Ability_4", throwIfNotFound: true);
            // Phone_Menu
            m_Phone_Menu = asset.FindActionMap("Phone_Menu", throwIfNotFound: true);
            m_Phone_Menu_Close = m_Phone_Menu.FindAction("Close", throwIfNotFound: true);
            m_Phone_Menu_Activate = m_Phone_Menu.FindAction("Activate", throwIfNotFound: true);
            // Dialogue_Menu
            m_Dialogue_Menu = asset.FindActionMap("Dialogue_Menu", throwIfNotFound: true);
            m_Dialogue_Menu_Procide_Dialogue = m_Dialogue_Menu.FindAction("Procide_Dialogue", throwIfNotFound: true);
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

        // Gameplay
        private readonly InputActionMap m_Gameplay;
        private IGameplayActions m_GameplayActionsCallbackInterface;
        private readonly InputAction m_Gameplay_Jump;
        private readonly InputAction m_Gameplay_Crouch;
        private readonly InputAction m_Gameplay_Interact;
        private readonly InputAction m_Gameplay_Open_Phone;
        private readonly InputAction m_Gameplay_Movement;
        private readonly InputAction m_Gameplay_Pause_Menu;
        private readonly InputAction m_Gameplay_Debug_Respawn;
        private readonly InputAction m_Gameplay_Attack;
        private readonly InputAction m_Gameplay_Debug_Damage;
        private readonly InputAction m_Gameplay_Debug_Full_Ammo;
        private readonly InputAction m_Gameplay_Use_Ability_1;
        private readonly InputAction m_Gameplay_Use_Ability_2;
        private readonly InputAction m_Gameplay_Use_Ability_3;
        private readonly InputAction m_Gameplay_Use_Ability_4;
        public struct GameplayActions
        {
            private @PlayerControls m_Wrapper;
            public GameplayActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
            public InputAction @Jump => m_Wrapper.m_Gameplay_Jump;
            public InputAction @Crouch => m_Wrapper.m_Gameplay_Crouch;
            public InputAction @Interact => m_Wrapper.m_Gameplay_Interact;
            public InputAction @Open_Phone => m_Wrapper.m_Gameplay_Open_Phone;
            public InputAction @Movement => m_Wrapper.m_Gameplay_Movement;
            public InputAction @Pause_Menu => m_Wrapper.m_Gameplay_Pause_Menu;
            public InputAction @Debug_Respawn => m_Wrapper.m_Gameplay_Debug_Respawn;
            public InputAction @Attack => m_Wrapper.m_Gameplay_Attack;
            public InputAction @Debug_Damage => m_Wrapper.m_Gameplay_Debug_Damage;
            public InputAction @Debug_Full_Ammo => m_Wrapper.m_Gameplay_Debug_Full_Ammo;
            public InputAction @Use_Ability_1 => m_Wrapper.m_Gameplay_Use_Ability_1;
            public InputAction @Use_Ability_2 => m_Wrapper.m_Gameplay_Use_Ability_2;
            public InputAction @Use_Ability_3 => m_Wrapper.m_Gameplay_Use_Ability_3;
            public InputAction @Use_Ability_4 => m_Wrapper.m_Gameplay_Use_Ability_4;
            public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
            public void SetCallbacks(IGameplayActions instance)
            {
                if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
                {
                    @Jump.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJump;
                    @Jump.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJump;
                    @Jump.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJump;
                    @Crouch.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCrouch;
                    @Crouch.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCrouch;
                    @Crouch.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnCrouch;
                    @Interact.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnInteract;
                    @Interact.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnInteract;
                    @Interact.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnInteract;
                    @Open_Phone.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnOpen_Phone;
                    @Open_Phone.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnOpen_Phone;
                    @Open_Phone.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnOpen_Phone;
                    @Movement.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMovement;
                    @Movement.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMovement;
                    @Movement.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMovement;
                    @Pause_Menu.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPause_Menu;
                    @Pause_Menu.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPause_Menu;
                    @Pause_Menu.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPause_Menu;
                    @Debug_Respawn.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDebug_Respawn;
                    @Debug_Respawn.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDebug_Respawn;
                    @Debug_Respawn.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDebug_Respawn;
                    @Attack.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAttack;
                    @Attack.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAttack;
                    @Attack.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAttack;
                    @Debug_Damage.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDebug_Damage;
                    @Debug_Damage.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDebug_Damage;
                    @Debug_Damage.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDebug_Damage;
                    @Debug_Full_Ammo.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDebug_Full_Ammo;
                    @Debug_Full_Ammo.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDebug_Full_Ammo;
                    @Debug_Full_Ammo.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDebug_Full_Ammo;
                    @Use_Ability_1.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnUse_Ability_1;
                    @Use_Ability_1.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnUse_Ability_1;
                    @Use_Ability_1.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnUse_Ability_1;
                    @Use_Ability_2.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnUse_Ability_2;
                    @Use_Ability_2.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnUse_Ability_2;
                    @Use_Ability_2.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnUse_Ability_2;
                    @Use_Ability_3.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnUse_Ability_3;
                    @Use_Ability_3.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnUse_Ability_3;
                    @Use_Ability_3.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnUse_Ability_3;
                    @Use_Ability_4.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnUse_Ability_4;
                    @Use_Ability_4.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnUse_Ability_4;
                    @Use_Ability_4.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnUse_Ability_4;
                }
                m_Wrapper.m_GameplayActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Jump.started += instance.OnJump;
                    @Jump.performed += instance.OnJump;
                    @Jump.canceled += instance.OnJump;
                    @Crouch.started += instance.OnCrouch;
                    @Crouch.performed += instance.OnCrouch;
                    @Crouch.canceled += instance.OnCrouch;
                    @Interact.started += instance.OnInteract;
                    @Interact.performed += instance.OnInteract;
                    @Interact.canceled += instance.OnInteract;
                    @Open_Phone.started += instance.OnOpen_Phone;
                    @Open_Phone.performed += instance.OnOpen_Phone;
                    @Open_Phone.canceled += instance.OnOpen_Phone;
                    @Movement.started += instance.OnMovement;
                    @Movement.performed += instance.OnMovement;
                    @Movement.canceled += instance.OnMovement;
                    @Pause_Menu.started += instance.OnPause_Menu;
                    @Pause_Menu.performed += instance.OnPause_Menu;
                    @Pause_Menu.canceled += instance.OnPause_Menu;
                    @Debug_Respawn.started += instance.OnDebug_Respawn;
                    @Debug_Respawn.performed += instance.OnDebug_Respawn;
                    @Debug_Respawn.canceled += instance.OnDebug_Respawn;
                    @Attack.started += instance.OnAttack;
                    @Attack.performed += instance.OnAttack;
                    @Attack.canceled += instance.OnAttack;
                    @Debug_Damage.started += instance.OnDebug_Damage;
                    @Debug_Damage.performed += instance.OnDebug_Damage;
                    @Debug_Damage.canceled += instance.OnDebug_Damage;
                    @Debug_Full_Ammo.started += instance.OnDebug_Full_Ammo;
                    @Debug_Full_Ammo.performed += instance.OnDebug_Full_Ammo;
                    @Debug_Full_Ammo.canceled += instance.OnDebug_Full_Ammo;
                    @Use_Ability_1.started += instance.OnUse_Ability_1;
                    @Use_Ability_1.performed += instance.OnUse_Ability_1;
                    @Use_Ability_1.canceled += instance.OnUse_Ability_1;
                    @Use_Ability_2.started += instance.OnUse_Ability_2;
                    @Use_Ability_2.performed += instance.OnUse_Ability_2;
                    @Use_Ability_2.canceled += instance.OnUse_Ability_2;
                    @Use_Ability_3.started += instance.OnUse_Ability_3;
                    @Use_Ability_3.performed += instance.OnUse_Ability_3;
                    @Use_Ability_3.canceled += instance.OnUse_Ability_3;
                    @Use_Ability_4.started += instance.OnUse_Ability_4;
                    @Use_Ability_4.performed += instance.OnUse_Ability_4;
                    @Use_Ability_4.canceled += instance.OnUse_Ability_4;
                }
            }
        }
        public GameplayActions @Gameplay => new GameplayActions(this);

        // Phone_Menu
        private readonly InputActionMap m_Phone_Menu;
        private IPhone_MenuActions m_Phone_MenuActionsCallbackInterface;
        private readonly InputAction m_Phone_Menu_Close;
        private readonly InputAction m_Phone_Menu_Activate;
        public struct Phone_MenuActions
        {
            private @PlayerControls m_Wrapper;
            public Phone_MenuActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
            public InputAction @Close => m_Wrapper.m_Phone_Menu_Close;
            public InputAction @Activate => m_Wrapper.m_Phone_Menu_Activate;
            public InputActionMap Get() { return m_Wrapper.m_Phone_Menu; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(Phone_MenuActions set) { return set.Get(); }
            public void SetCallbacks(IPhone_MenuActions instance)
            {
                if (m_Wrapper.m_Phone_MenuActionsCallbackInterface != null)
                {
                    @Close.started -= m_Wrapper.m_Phone_MenuActionsCallbackInterface.OnClose;
                    @Close.performed -= m_Wrapper.m_Phone_MenuActionsCallbackInterface.OnClose;
                    @Close.canceled -= m_Wrapper.m_Phone_MenuActionsCallbackInterface.OnClose;
                    @Activate.started -= m_Wrapper.m_Phone_MenuActionsCallbackInterface.OnActivate;
                    @Activate.performed -= m_Wrapper.m_Phone_MenuActionsCallbackInterface.OnActivate;
                    @Activate.canceled -= m_Wrapper.m_Phone_MenuActionsCallbackInterface.OnActivate;
                }
                m_Wrapper.m_Phone_MenuActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Close.started += instance.OnClose;
                    @Close.performed += instance.OnClose;
                    @Close.canceled += instance.OnClose;
                    @Activate.started += instance.OnActivate;
                    @Activate.performed += instance.OnActivate;
                    @Activate.canceled += instance.OnActivate;
                }
            }
        }
        public Phone_MenuActions @Phone_Menu => new Phone_MenuActions(this);

        // Dialogue_Menu
        private readonly InputActionMap m_Dialogue_Menu;
        private IDialogue_MenuActions m_Dialogue_MenuActionsCallbackInterface;
        private readonly InputAction m_Dialogue_Menu_Procide_Dialogue;
        public struct Dialogue_MenuActions
        {
            private @PlayerControls m_Wrapper;
            public Dialogue_MenuActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
            public InputAction @Procide_Dialogue => m_Wrapper.m_Dialogue_Menu_Procide_Dialogue;
            public InputActionMap Get() { return m_Wrapper.m_Dialogue_Menu; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(Dialogue_MenuActions set) { return set.Get(); }
            public void SetCallbacks(IDialogue_MenuActions instance)
            {
                if (m_Wrapper.m_Dialogue_MenuActionsCallbackInterface != null)
                {
                    @Procide_Dialogue.started -= m_Wrapper.m_Dialogue_MenuActionsCallbackInterface.OnProcide_Dialogue;
                    @Procide_Dialogue.performed -= m_Wrapper.m_Dialogue_MenuActionsCallbackInterface.OnProcide_Dialogue;
                    @Procide_Dialogue.canceled -= m_Wrapper.m_Dialogue_MenuActionsCallbackInterface.OnProcide_Dialogue;
                }
                m_Wrapper.m_Dialogue_MenuActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Procide_Dialogue.started += instance.OnProcide_Dialogue;
                    @Procide_Dialogue.performed += instance.OnProcide_Dialogue;
                    @Procide_Dialogue.canceled += instance.OnProcide_Dialogue;
                }
            }
        }
        public Dialogue_MenuActions @Dialogue_Menu => new Dialogue_MenuActions(this);
        public interface IGameplayActions
        {
            void OnJump(InputAction.CallbackContext context);
            void OnCrouch(InputAction.CallbackContext context);
            void OnInteract(InputAction.CallbackContext context);
            void OnOpen_Phone(InputAction.CallbackContext context);
            void OnMovement(InputAction.CallbackContext context);
            void OnPause_Menu(InputAction.CallbackContext context);
            void OnDebug_Respawn(InputAction.CallbackContext context);
            void OnAttack(InputAction.CallbackContext context);
            void OnDebug_Damage(InputAction.CallbackContext context);
            void OnDebug_Full_Ammo(InputAction.CallbackContext context);
            void OnUse_Ability_1(InputAction.CallbackContext context);
            void OnUse_Ability_2(InputAction.CallbackContext context);
            void OnUse_Ability_3(InputAction.CallbackContext context);
            void OnUse_Ability_4(InputAction.CallbackContext context);
        }
        public interface IPhone_MenuActions
        {
            void OnClose(InputAction.CallbackContext context);
            void OnActivate(InputAction.CallbackContext context);
        }
        public interface IDialogue_MenuActions
        {
            void OnProcide_Dialogue(InputAction.CallbackContext context);
        }
    }
}
