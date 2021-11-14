// GENERATED AUTOMATICALLY FROM 'Assets/Settings/Input/GameInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace Jammers
{
    public class @GameInput : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @GameInput()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""GameInput"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""83fca79e-daba-4e61-883b-46e2c6b20a46"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""70ba075a-c99d-4c2a-8e36-b737e01335d7"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Attack"",
                    ""type"": ""Button"",
                    ""id"": ""4ad49527-8125-407e-b177-120684ea2e04"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""e233eb3c-9c54-4220-8de6-fbe22836079e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""d00fc324-8acc-40c6-8fd1-f293e8640638"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""OpenInventory"",
                    ""type"": ""Button"",
                    ""id"": ""7855c236-a3aa-44ae-875b-00c276444b16"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""Button"",
                    ""id"": ""92e1ff29-85a3-4519-831d-5b61d3ac88c1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""41425813-3c80-4f99-8531-d48d397890cd"",
                    ""path"": ""<Keyboard>/f"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad;MouseAndKeyboard"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1f454265-28bc-4912-8feb-f8bd95c9f876"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad;MouseAndKeyboard"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1d975747-2bd3-45fd-ad79-a33baad8c9a0"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad;MouseAndKeyboard"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4e624bee-2ec6-4e52-a70e-bb8a00abf658"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad;Gamepad"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b4d88690-5d3f-4319-a983-5613a265eaf3"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad;MouseAndKeyboard"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8e9c9fcd-13e3-4a0b-b657-bd47c598487b"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad;Gamepad"",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c71832ce-b741-438b-8e01-c0a351f13cfd"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad;MouseAndKeyboard"",
                    ""action"": ""OpenInventory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""70ff22bc-a6f1-47f3-818b-c354aa205cb8"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad;Gamepad"",
                    ""action"": ""OpenInventory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""332272ff-27eb-4d6b-8f70-d172e23f4549"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad;MouseAndKeyboard"",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4f393ffc-e3ae-46a6-aab0-f2b054de9a9b"",
                    ""path"": ""<Keyboard>/rightShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad;MouseAndKeyboard"",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7b00cf23-c73b-4861-86a3-613526121172"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad;Gamepad"",
                    ""action"": ""Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Keyboard WASD"",
                    ""id"": ""14365b6c-f889-4491-9ffb-ca47ea38e001"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2"",
                    ""groups"": ""MouseAndKeyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""8cd7845f-48ff-4219-bb16-f2b12b380d0f"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseAndKeyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""a390c1fb-20bc-4c9f-b163-557231a3456e"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseAndKeyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""42d01021-5f53-4a84-9d91-d89e5c01bb8f"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseAndKeyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""bc1916fd-aba7-41de-9817-d1f04ce7d76b"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseAndKeyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard Arrows"",
                    ""id"": ""e5f4be53-b1f2-4b2a-b749-4cca64798c4f"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2"",
                    ""groups"": ""MouseAndKeyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""a0baaf74-7243-41f4-a5a3-eb2e16e00ce8"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseAndKeyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a588d90f-6f01-42c9-8e28-62ce83e499e2"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseAndKeyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""afe868fe-0c51-4c10-9ca4-02a15502ceac"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseAndKeyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""8c07ce66-2553-4efc-a839-68304b4b9cf5"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseAndKeyboard"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Gamepad Left Stick"",
                    ""id"": ""2ad8128a-6032-4e52-85eb-c8935d78904b"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": ""StickDeadzone,ScaleVector2(x=1.4,y=1.4)"",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""731214a9-36ad-4de0-8410-bf087a14753f"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""d60e6fb4-6e7f-4519-84c6-7eb636cb8ddf"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""03466371-8a10-4698-a4ce-9e7f6e96da42"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""6be2f28b-5caa-4bfe-9084-a9ca84bd2a55"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Menus"",
            ""id"": ""6b0ccc80-1d2b-4d11-87ac-306c34deac0d"",
            ""actions"": [
                {
                    ""name"": ""MoveSelection"",
                    ""type"": ""Value"",
                    ""id"": ""410221a3-10df-4b7b-b515-1dac3ace175c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""StickDeadzone"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Navigate"",
                    ""type"": ""Value"",
                    ""id"": ""9bc7c193-d12e-4dd0-b13c-371ffd758176"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Submit"",
                    ""type"": ""Button"",
                    ""id"": ""030b0c60-88f2-421e-91c1-c47aa3826962"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Confirm"",
                    ""type"": ""Button"",
                    ""id"": ""670ff138-2c58-4bee-92f0-f47eb9427a81"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""5abde287-7db6-444f-ab72-602aba881886"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MouseMove"",
                    ""type"": ""PassThrough"",
                    ""id"": ""21d1c1d7-4330-4692-9cfb-e6080c884c6d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Unpause"",
                    ""type"": ""Button"",
                    ""id"": ""9b7cf4ae-bab7-4cdd-8d84-3517b85e6567"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ChangeTab"",
                    ""type"": ""Button"",
                    ""id"": ""69a74eec-e33c-4b2c-a72e-f1db3b559c57"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""InventoryActionButton"",
                    ""type"": ""Button"",
                    ""id"": ""0dd2ee0a-b48b-4027-b1a7-cb978c37ad58"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""SaveActionButton"",
                    ""type"": ""Button"",
                    ""id"": ""7189695d-7c5c-4917-b589-3228410a2a9f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""ResetActionButton"",
                    ""type"": ""Button"",
                    ""id"": ""925e64ed-e2fc-4cb4-8509-dc5e19fdeee6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Click"",
                    ""type"": ""PassThrough"",
                    ""id"": ""b4dc4e10-f573-4793-a80c-a2c0814295e5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Point"",
                    ""type"": ""PassThrough"",
                    ""id"": ""ecc2a8ff-986d-49bb-b4b0-271fcaa4b0e6"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RightClick"",
                    ""type"": ""PassThrough"",
                    ""id"": ""8f1932a8-c9bd-4cae-a563-4b1c2c1edc64"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CloseInventory"",
                    ""type"": ""Button"",
                    ""id"": ""9af61dcb-101f-4fe9-b9d1-3d31c4ae73b0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Keyboard WASD"",
                    ""id"": ""e22ac7e4-e3fb-4322-a568-94874b08e29f"",
                    ""path"": ""2DVector(mode=1)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveSelection"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""ed3f20c4-5494-4ff8-9ae9-0537e09bd6d1"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad;MouseAndKeyboard"",
                    ""action"": ""MoveSelection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""699c74fe-bec0-4c44-962b-2fd28fceabdc"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad;MouseAndKeyboard"",
                    ""action"": ""MoveSelection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""ba3a21f7-6748-4d05-b9f1-583df633765c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad;MouseAndKeyboard"",
                    ""action"": ""MoveSelection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c836afe3-09e6-4680-8b54-eb5f3ff336ef"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad;MouseAndKeyboard"",
                    ""action"": ""MoveSelection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard Arrows"",
                    ""id"": ""3ec623eb-fc3f-4a14-ad56-fec5de04431a"",
                    ""path"": ""2DVector(mode=1)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveSelection"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""13d5b8ea-d099-4c26-b7c7-cf377eccfad1"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad;MouseAndKeyboard"",
                    ""action"": ""MoveSelection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""042b02c1-64a6-42ee-b934-9c9503752ffa"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad;MouseAndKeyboard"",
                    ""action"": ""MoveSelection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e3e7d852-9b1b-4667-a763-8e1eea0d970c"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad;MouseAndKeyboard"",
                    ""action"": ""MoveSelection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""467e6bfa-1944-4d2a-b84b-35def2e2413d"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad;MouseAndKeyboard"",
                    ""action"": ""MoveSelection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Gamepad Dpad"",
                    ""id"": ""b51a018a-c7fe-4f88-8fdd-04c161ae3103"",
                    ""path"": ""2DVector(mode=1)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveSelection"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""2a679fbe-f23f-4882-a2dc-e5cfdf2dbaf2"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad;Gamepad"",
                    ""action"": ""MoveSelection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""2cb41d75-4796-4d3d-8144-340617a4b3fe"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad;Gamepad"",
                    ""action"": ""MoveSelection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""4bf3d097-c0fc-442e-b016-c8741fd0271a"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad;Gamepad"",
                    ""action"": ""MoveSelection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f7f45cac-90be-4f4f-adc8-275b74387bf9"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad;Gamepad"",
                    ""action"": ""MoveSelection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard"",
                    ""id"": ""eb1a0f77-6b9f-4bfd-a66a-bc718161af74"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""8dead8e4-99b0-4178-b95c-b9fdb23596e2"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;MouseAndKeyboard"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e1bfd338-026a-4ae2-b376-f93f246f4eef"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;MouseAndKeyboard"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""cc8e9256-2958-466a-a3bb-e39d892971c7"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;MouseAndKeyboard"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""3ce3e3a9-f2ac-4c72-85f7-01e5bf0c88d5"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;MouseAndKeyboard"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b32a52cf-1b39-4bc1-8062-67dae10d1379"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;MouseAndKeyboard"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""f8ca9c19-fa72-485f-9a3e-09a8afa05046"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;MouseAndKeyboard"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""f1c7ca39-0475-41d3-a0e3-092d1bf60b10"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;MouseAndKeyboard"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""fd958cd6-fe40-420f-804c-d54d917e922a"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;MouseAndKeyboard"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""b8a4e56c-f952-49af-b30e-bbccdf4efb82"",
                    ""path"": ""*/{Submit}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""MouseAndKeyboard;Gamepad"",
                    ""action"": ""Submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""aa223c5c-2595-4710-b716-1f0b0599eeda"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad;MouseAndKeyboard"",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9f5c5a06-53d0-4455-a315-67d66702804b"",
                    ""path"": ""<Keyboard>/enter"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad;MouseAndKeyboard"",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4acc15e4-a013-4c2f-88ed-f6fdd16b868c"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad;MouseAndKeyboard"",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e707da3f-9782-471d-aef1-3a2cfbad7321"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad;MouseAndKeyboard"",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9eccda1c-78d2-427a-b040-d108c79032c6"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad;Gamepad"",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e775f4cb-920a-4daf-a2eb-3935a93f15fa"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;KeyboardOrGamepad;MouseAndKeyboard"",
                    ""action"": ""MouseMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e9d2d79e-7780-4727-a23a-ea2e32c5eedb"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad;MouseAndKeyboard"",
                    ""action"": ""Unpause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""LeftRight [Keyboard]"",
                    ""id"": ""f54e2884-07e3-4cc1-80e3-315b8e884c18"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeTab"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""1eff5b4b-07b2-4551-98e4-b8e3744f217b"",
                    ""path"": ""<Keyboard>/t"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad;MouseAndKeyboard"",
                    ""action"": ""ChangeTab"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""a81d9b64-78e7-4177-b047-563a2eb39818"",
                    ""path"": ""<Keyboard>/y"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad;MouseAndKeyboard"",
                    ""action"": ""ChangeTab"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""4a862546-fb06-422f-81db-3c1f9efedc29"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad;MouseAndKeyboard"",
                    ""action"": ""InventoryActionButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0ccaa240-3e25-465e-a72d-3762214a6305"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad;Gamepad"",
                    ""action"": ""InventoryActionButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""472177a6-cfae-4f98-bdea-b85298fb4965"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad;MouseAndKeyboard"",
                    ""action"": ""SaveActionButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0e5ed30c-bc38-4a44-8460-9fbf450e8d5c"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad;Gamepad"",
                    ""action"": ""SaveActionButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5790547e-17bc-4667-ad0d-434800819710"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad;MouseAndKeyboard"",
                    ""action"": ""ResetActionButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eacab5be-5ad7-4cb3-b5a5-586d8590b798"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad;Gamepad"",
                    ""action"": ""ResetActionButton"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b4be1cae-367a-467b-9142-5e6bd871812e"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;MouseAndKeyboard"",
                    ""action"": ""Click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5f900670-2994-4661-a230-c869149cd62e"",
                    ""path"": ""<Mouse>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;MouseAndKeyboard"",
                    ""action"": ""Point"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""21b4e995-4717-4a73-b11b-c1099b9a0c0c"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard&Mouse;MouseAndKeyboard"",
                    ""action"": ""RightClick"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1a0614fd-0ff7-4c2c-8bcc-0cfee95e767c"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad;MouseAndKeyboard"",
                    ""action"": ""CloseInventory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1e09dc4c-95be-4474-a9fe-0c631f1accba"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad;Gamepad"",
                    ""action"": ""CloseInventory"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""LeftRight Shoulder"",
                    ""id"": ""ff691b04-e07d-4690-a61f-78d3ba72c05b"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ChangeTab"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Negative"",
                    ""id"": ""ca2903fb-b591-4892-a9ac-2b9c7833f57a"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad"",
                    ""action"": ""ChangeTab"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Positive"",
                    ""id"": ""b16da2ae-f5a0-48d4-9e18-f1ac0044c616"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad;Gamepad"",
                    ""action"": ""ChangeTab"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""c98d1308-fc4c-4573-9f33-64db0ec6b1ad"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad;Gamepad"",
                    ""action"": ""Unpause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b6949d34-1b2e-4c43-b4e5-78bce1a76a6f"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad;Gamepad"",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Gamepad"",
                    ""id"": ""4f520e5d-58b2-4c4a-970b-6b680acc7c77"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""6855b52f-9c0b-4156-b9ac-484fdf65be0e"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""up"",
                    ""id"": ""bb0c4c2e-9782-446b-b9a5-0da4bc47fd6f"",
                    ""path"": ""<Gamepad>/rightStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""e8e985f2-0f78-4acc-ac54-de76e211936f"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""b9e17863-21cb-4546-bcba-cf7446afe8f9"",
                    ""path"": ""<Gamepad>/rightStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""7e9a17ec-da18-41e6-9fea-17be617d13a8"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""2e1841d0-3d7f-4fa6-872a-635cbbea3389"",
                    ""path"": ""<Gamepad>/rightStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""476c64a4-1ec3-45be-be44-8ff908ec8736"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""6008451e-3957-4e8d-bd7a-dd15237a8c20"",
                    ""path"": ""<Gamepad>/rightStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""11e39367-8ef5-432f-8dfe-8edbe7da80cc"",
                    ""path"": ""<Gamepad>/dpad"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": "";Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Joystick"",
                    ""id"": ""d0a1f787-aa53-414b-aceb-49446ce93f5a"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Navigate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""bf1fa80d-c015-4e08-b7ad-f3c945acbb79"",
                    ""path"": ""<Joystick>/stick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick;Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ed2aa3af-5085-4992-a182-79ede6000fe8"",
                    ""path"": ""<Joystick>/stick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick;Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""75126b29-fc6b-4acb-972f-b2343836e0b8"",
                    ""path"": ""<Joystick>/stick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick;Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""3e84a8ee-9144-4194-af8a-2b4581f53d8e"",
                    ""path"": ""<Joystick>/stick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Joystick;Gamepad"",
                    ""action"": ""Navigate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Gamepad Left Stick"",
                    ""id"": ""28799116-b6a3-48c9-9b55-825f77aaeebe"",
                    ""path"": ""2DVector(mode=1)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveSelection"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""499942fd-de59-4ac0-8b7e-ade8edaafd39"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad;Gamepad"",
                    ""action"": ""MoveSelection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""e4dcb5fe-e866-4e44-9f85-afd3c3630f9a"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad;Gamepad"",
                    ""action"": ""MoveSelection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""7fe80abe-dd2d-4d91-9ff2-4b51aeb18499"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad;Gamepad"",
                    ""action"": ""MoveSelection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""96b950e4-28c9-41b5-941b-a2577ae8dd78"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad;Gamepad"",
                    ""action"": ""MoveSelection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Dialogues"",
            ""id"": ""4498b302-7eea-48f9-80ed-10c1ec056c23"",
            ""actions"": [
                {
                    ""name"": ""MoveSelection"",
                    ""type"": ""Value"",
                    ""id"": ""41564bf3-0ad1-4060-8482-21003b8ca6e7"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""StickDeadzone"",
                    ""interactions"": """"
                },
                {
                    ""name"": ""AdvanceDialogue"",
                    ""type"": ""Button"",
                    ""id"": ""b27dd560-e21b-4806-9b62-6d96f4856fb8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Keyboard WASD"",
                    ""id"": ""baaffe0b-7ddd-462f-9087-2fe95f657ff6"",
                    ""path"": ""2DVector(mode=1)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveSelection"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""0e69ad86-2851-42dc-9d61-f14be5b399c4"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad;MouseAndKeyboard"",
                    ""action"": ""MoveSelection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""1386d15e-fa2b-4c00-a258-72d7e2585a81"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad;MouseAndKeyboard"",
                    ""action"": ""MoveSelection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""8f0fa14e-c57f-49f9-a9e6-058bd45b72d0"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad;MouseAndKeyboard"",
                    ""action"": ""MoveSelection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""2a67a742-bc80-4ccd-a5d4-78bdcd1b5210"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad;MouseAndKeyboard"",
                    ""action"": ""MoveSelection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Keyboard Arrows"",
                    ""id"": ""209fee5d-7bc2-4fb8-a058-de0993584d25"",
                    ""path"": ""2DVector(mode=1)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveSelection"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""fc3610ea-fda7-4e8c-a652-5e8a40158d89"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad;MouseAndKeyboard"",
                    ""action"": ""MoveSelection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f0c7dfe1-1036-429f-b730-815e59642e56"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad;MouseAndKeyboard"",
                    ""action"": ""MoveSelection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b69f88eb-c5a5-4860-9f8f-94680cf1ceab"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad;MouseAndKeyboard"",
                    ""action"": ""MoveSelection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""91423236-1745-42af-8dbe-6612f56e62b7"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad;MouseAndKeyboard"",
                    ""action"": ""MoveSelection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""e78ec386-b029-4059-a053-f868f241dab1"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad;MouseAndKeyboard"",
                    ""action"": ""AdvanceDialogue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0d0591f9-a7b6-4b56-8850-af9eb16830ed"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad;Gamepad"",
                    ""action"": ""AdvanceDialogue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Gamepad Left Stick"",
                    ""id"": ""debd9aef-ec2e-4d17-b025-6b7ad652f2e2"",
                    ""path"": ""2DVector(mode=1)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MoveSelection"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""c4382458-18e7-4c02-a3ff-eedc9bee2272"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad;Gamepad"",
                    ""action"": ""MoveSelection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""8669af3b-e1e4-4063-92a6-b13897cc8a6b"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad;Gamepad"",
                    ""action"": ""MoveSelection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Gamepad Dpad"",
                    ""id"": ""052dddcc-94c7-4289-844e-958855bcad40"",
                    ""path"": ""2DVector(mode=1)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad"",
                    ""action"": ""MoveSelection"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""90bc5ba8-9bc5-444f-9ec0-15548b40c2eb"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad;Gamepad"",
                    ""action"": ""MoveSelection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""1f932f59-a6a9-44a6-8efc-f6651e38bf4f"",
                    ""path"": ""<Gamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad;Gamepad"",
                    ""action"": ""MoveSelection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""2a8423cd-6588-4b51-84bf-2a5c2c130509"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad;Gamepad"",
                    ""action"": ""MoveSelection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""6d66e8fe-9424-4b59-a358-d8535c1057f3"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad;Gamepad"",
                    ""action"": ""MoveSelection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""f56fa0b1-0d2b-4113-b0a2-1d1770cb4856"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad;Gamepad"",
                    ""action"": ""MoveSelection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""7092592e-13de-4aca-b743-56dd7bca90a1"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad;Gamepad"",
                    ""action"": ""MoveSelection"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""Cheats"",
            ""id"": ""e79ab79f-b51a-4645-a07a-7b6b3148a6f4"",
            ""actions"": [
                {
                    ""name"": ""OpenCheatMenu"",
                    ""type"": ""Button"",
                    ""id"": ""3ef095f0-ce58-4714-8e3b-d6bf43d9c4b7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e4dd93b2-c070-4c19-9df4-4304f531408f"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad;MouseAndKeyboard"",
                    ""action"": ""OpenCheatMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""180fec39-cba0-4922-992b-f1c358da62d3"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad;Gamepad"",
                    ""action"": ""OpenCheatMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""adf5d7e8-aee6-4e09-ae8a-19d81432b404"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KeyboardOrGamepad;Gamepad"",
                    ""action"": ""OpenCheatMenu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""MouseAndKeyboard"",
            ""bindingGroup"": ""MouseAndKeyboard"",
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
            // Gameplay
            m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
            m_Gameplay_Move = m_Gameplay.FindAction("Move", throwIfNotFound: true);
            m_Gameplay_Attack = m_Gameplay.FindAction("Attack", throwIfNotFound: true);
            m_Gameplay_Interact = m_Gameplay.FindAction("Interact", throwIfNotFound: true);
            m_Gameplay_Pause = m_Gameplay.FindAction("Pause", throwIfNotFound: true);
            m_Gameplay_OpenInventory = m_Gameplay.FindAction("OpenInventory", throwIfNotFound: true);
            m_Gameplay_Dash = m_Gameplay.FindAction("Dash", throwIfNotFound: true);
            // Menus
            m_Menus = asset.FindActionMap("Menus", throwIfNotFound: true);
            m_Menus_MoveSelection = m_Menus.FindAction("MoveSelection", throwIfNotFound: true);
            m_Menus_Navigate = m_Menus.FindAction("Navigate", throwIfNotFound: true);
            m_Menus_Submit = m_Menus.FindAction("Submit", throwIfNotFound: true);
            m_Menus_Confirm = m_Menus.FindAction("Confirm", throwIfNotFound: true);
            m_Menus_Cancel = m_Menus.FindAction("Cancel", throwIfNotFound: true);
            m_Menus_MouseMove = m_Menus.FindAction("MouseMove", throwIfNotFound: true);
            m_Menus_Unpause = m_Menus.FindAction("Unpause", throwIfNotFound: true);
            m_Menus_ChangeTab = m_Menus.FindAction("ChangeTab", throwIfNotFound: true);
            m_Menus_InventoryActionButton = m_Menus.FindAction("InventoryActionButton", throwIfNotFound: true);
            m_Menus_SaveActionButton = m_Menus.FindAction("SaveActionButton", throwIfNotFound: true);
            m_Menus_ResetActionButton = m_Menus.FindAction("ResetActionButton", throwIfNotFound: true);
            m_Menus_Click = m_Menus.FindAction("Click", throwIfNotFound: true);
            m_Menus_Point = m_Menus.FindAction("Point", throwIfNotFound: true);
            m_Menus_RightClick = m_Menus.FindAction("RightClick", throwIfNotFound: true);
            m_Menus_CloseInventory = m_Menus.FindAction("CloseInventory", throwIfNotFound: true);
            // Dialogues
            m_Dialogues = asset.FindActionMap("Dialogues", throwIfNotFound: true);
            m_Dialogues_MoveSelection = m_Dialogues.FindAction("MoveSelection", throwIfNotFound: true);
            m_Dialogues_AdvanceDialogue = m_Dialogues.FindAction("AdvanceDialogue", throwIfNotFound: true);
            // Cheats
            m_Cheats = asset.FindActionMap("Cheats", throwIfNotFound: true);
            m_Cheats_OpenCheatMenu = m_Cheats.FindAction("OpenCheatMenu", throwIfNotFound: true);
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
        private readonly InputAction m_Gameplay_Move;
        private readonly InputAction m_Gameplay_Attack;
        private readonly InputAction m_Gameplay_Interact;
        private readonly InputAction m_Gameplay_Pause;
        private readonly InputAction m_Gameplay_OpenInventory;
        private readonly InputAction m_Gameplay_Dash;
        public struct GameplayActions
        {
            private @GameInput m_Wrapper;
            public GameplayActions(@GameInput wrapper) { m_Wrapper = wrapper; }
            public InputAction @Move => m_Wrapper.m_Gameplay_Move;
            public InputAction @Attack => m_Wrapper.m_Gameplay_Attack;
            public InputAction @Interact => m_Wrapper.m_Gameplay_Interact;
            public InputAction @Pause => m_Wrapper.m_Gameplay_Pause;
            public InputAction @OpenInventory => m_Wrapper.m_Gameplay_OpenInventory;
            public InputAction @Dash => m_Wrapper.m_Gameplay_Dash;
            public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
            public void SetCallbacks(IGameplayActions instance)
            {
                if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
                {
                    @Move.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                    @Move.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                    @Move.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMove;
                    @Attack.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAttack;
                    @Attack.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAttack;
                    @Attack.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnAttack;
                    @Interact.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnInteract;
                    @Interact.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnInteract;
                    @Interact.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnInteract;
                    @Pause.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPause;
                    @Pause.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPause;
                    @Pause.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnPause;
                    @OpenInventory.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnOpenInventory;
                    @OpenInventory.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnOpenInventory;
                    @OpenInventory.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnOpenInventory;
                    @Dash.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDash;
                    @Dash.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDash;
                    @Dash.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnDash;
                }
                m_Wrapper.m_GameplayActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Move.started += instance.OnMove;
                    @Move.performed += instance.OnMove;
                    @Move.canceled += instance.OnMove;
                    @Attack.started += instance.OnAttack;
                    @Attack.performed += instance.OnAttack;
                    @Attack.canceled += instance.OnAttack;
                    @Interact.started += instance.OnInteract;
                    @Interact.performed += instance.OnInteract;
                    @Interact.canceled += instance.OnInteract;
                    @Pause.started += instance.OnPause;
                    @Pause.performed += instance.OnPause;
                    @Pause.canceled += instance.OnPause;
                    @OpenInventory.started += instance.OnOpenInventory;
                    @OpenInventory.performed += instance.OnOpenInventory;
                    @OpenInventory.canceled += instance.OnOpenInventory;
                    @Dash.started += instance.OnDash;
                    @Dash.performed += instance.OnDash;
                    @Dash.canceled += instance.OnDash;
                }
            }
        }
        public GameplayActions @Gameplay => new GameplayActions(this);

        // Menus
        private readonly InputActionMap m_Menus;
        private IMenusActions m_MenusActionsCallbackInterface;
        private readonly InputAction m_Menus_MoveSelection;
        private readonly InputAction m_Menus_Navigate;
        private readonly InputAction m_Menus_Submit;
        private readonly InputAction m_Menus_Confirm;
        private readonly InputAction m_Menus_Cancel;
        private readonly InputAction m_Menus_MouseMove;
        private readonly InputAction m_Menus_Unpause;
        private readonly InputAction m_Menus_ChangeTab;
        private readonly InputAction m_Menus_InventoryActionButton;
        private readonly InputAction m_Menus_SaveActionButton;
        private readonly InputAction m_Menus_ResetActionButton;
        private readonly InputAction m_Menus_Click;
        private readonly InputAction m_Menus_Point;
        private readonly InputAction m_Menus_RightClick;
        private readonly InputAction m_Menus_CloseInventory;
        public struct MenusActions
        {
            private @GameInput m_Wrapper;
            public MenusActions(@GameInput wrapper) { m_Wrapper = wrapper; }
            public InputAction @MoveSelection => m_Wrapper.m_Menus_MoveSelection;
            public InputAction @Navigate => m_Wrapper.m_Menus_Navigate;
            public InputAction @Submit => m_Wrapper.m_Menus_Submit;
            public InputAction @Confirm => m_Wrapper.m_Menus_Confirm;
            public InputAction @Cancel => m_Wrapper.m_Menus_Cancel;
            public InputAction @MouseMove => m_Wrapper.m_Menus_MouseMove;
            public InputAction @Unpause => m_Wrapper.m_Menus_Unpause;
            public InputAction @ChangeTab => m_Wrapper.m_Menus_ChangeTab;
            public InputAction @InventoryActionButton => m_Wrapper.m_Menus_InventoryActionButton;
            public InputAction @SaveActionButton => m_Wrapper.m_Menus_SaveActionButton;
            public InputAction @ResetActionButton => m_Wrapper.m_Menus_ResetActionButton;
            public InputAction @Click => m_Wrapper.m_Menus_Click;
            public InputAction @Point => m_Wrapper.m_Menus_Point;
            public InputAction @RightClick => m_Wrapper.m_Menus_RightClick;
            public InputAction @CloseInventory => m_Wrapper.m_Menus_CloseInventory;
            public InputActionMap Get() { return m_Wrapper.m_Menus; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(MenusActions set) { return set.Get(); }
            public void SetCallbacks(IMenusActions instance)
            {
                if (m_Wrapper.m_MenusActionsCallbackInterface != null)
                {
                    @MoveSelection.started -= m_Wrapper.m_MenusActionsCallbackInterface.OnMoveSelection;
                    @MoveSelection.performed -= m_Wrapper.m_MenusActionsCallbackInterface.OnMoveSelection;
                    @MoveSelection.canceled -= m_Wrapper.m_MenusActionsCallbackInterface.OnMoveSelection;
                    @Navigate.started -= m_Wrapper.m_MenusActionsCallbackInterface.OnNavigate;
                    @Navigate.performed -= m_Wrapper.m_MenusActionsCallbackInterface.OnNavigate;
                    @Navigate.canceled -= m_Wrapper.m_MenusActionsCallbackInterface.OnNavigate;
                    @Submit.started -= m_Wrapper.m_MenusActionsCallbackInterface.OnSubmit;
                    @Submit.performed -= m_Wrapper.m_MenusActionsCallbackInterface.OnSubmit;
                    @Submit.canceled -= m_Wrapper.m_MenusActionsCallbackInterface.OnSubmit;
                    @Confirm.started -= m_Wrapper.m_MenusActionsCallbackInterface.OnConfirm;
                    @Confirm.performed -= m_Wrapper.m_MenusActionsCallbackInterface.OnConfirm;
                    @Confirm.canceled -= m_Wrapper.m_MenusActionsCallbackInterface.OnConfirm;
                    @Cancel.started -= m_Wrapper.m_MenusActionsCallbackInterface.OnCancel;
                    @Cancel.performed -= m_Wrapper.m_MenusActionsCallbackInterface.OnCancel;
                    @Cancel.canceled -= m_Wrapper.m_MenusActionsCallbackInterface.OnCancel;
                    @MouseMove.started -= m_Wrapper.m_MenusActionsCallbackInterface.OnMouseMove;
                    @MouseMove.performed -= m_Wrapper.m_MenusActionsCallbackInterface.OnMouseMove;
                    @MouseMove.canceled -= m_Wrapper.m_MenusActionsCallbackInterface.OnMouseMove;
                    @Unpause.started -= m_Wrapper.m_MenusActionsCallbackInterface.OnUnpause;
                    @Unpause.performed -= m_Wrapper.m_MenusActionsCallbackInterface.OnUnpause;
                    @Unpause.canceled -= m_Wrapper.m_MenusActionsCallbackInterface.OnUnpause;
                    @ChangeTab.started -= m_Wrapper.m_MenusActionsCallbackInterface.OnChangeTab;
                    @ChangeTab.performed -= m_Wrapper.m_MenusActionsCallbackInterface.OnChangeTab;
                    @ChangeTab.canceled -= m_Wrapper.m_MenusActionsCallbackInterface.OnChangeTab;
                    @InventoryActionButton.started -= m_Wrapper.m_MenusActionsCallbackInterface.OnInventoryActionButton;
                    @InventoryActionButton.performed -= m_Wrapper.m_MenusActionsCallbackInterface.OnInventoryActionButton;
                    @InventoryActionButton.canceled -= m_Wrapper.m_MenusActionsCallbackInterface.OnInventoryActionButton;
                    @SaveActionButton.started -= m_Wrapper.m_MenusActionsCallbackInterface.OnSaveActionButton;
                    @SaveActionButton.performed -= m_Wrapper.m_MenusActionsCallbackInterface.OnSaveActionButton;
                    @SaveActionButton.canceled -= m_Wrapper.m_MenusActionsCallbackInterface.OnSaveActionButton;
                    @ResetActionButton.started -= m_Wrapper.m_MenusActionsCallbackInterface.OnResetActionButton;
                    @ResetActionButton.performed -= m_Wrapper.m_MenusActionsCallbackInterface.OnResetActionButton;
                    @ResetActionButton.canceled -= m_Wrapper.m_MenusActionsCallbackInterface.OnResetActionButton;
                    @Click.started -= m_Wrapper.m_MenusActionsCallbackInterface.OnClick;
                    @Click.performed -= m_Wrapper.m_MenusActionsCallbackInterface.OnClick;
                    @Click.canceled -= m_Wrapper.m_MenusActionsCallbackInterface.OnClick;
                    @Point.started -= m_Wrapper.m_MenusActionsCallbackInterface.OnPoint;
                    @Point.performed -= m_Wrapper.m_MenusActionsCallbackInterface.OnPoint;
                    @Point.canceled -= m_Wrapper.m_MenusActionsCallbackInterface.OnPoint;
                    @RightClick.started -= m_Wrapper.m_MenusActionsCallbackInterface.OnRightClick;
                    @RightClick.performed -= m_Wrapper.m_MenusActionsCallbackInterface.OnRightClick;
                    @RightClick.canceled -= m_Wrapper.m_MenusActionsCallbackInterface.OnRightClick;
                    @CloseInventory.started -= m_Wrapper.m_MenusActionsCallbackInterface.OnCloseInventory;
                    @CloseInventory.performed -= m_Wrapper.m_MenusActionsCallbackInterface.OnCloseInventory;
                    @CloseInventory.canceled -= m_Wrapper.m_MenusActionsCallbackInterface.OnCloseInventory;
                }
                m_Wrapper.m_MenusActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @MoveSelection.started += instance.OnMoveSelection;
                    @MoveSelection.performed += instance.OnMoveSelection;
                    @MoveSelection.canceled += instance.OnMoveSelection;
                    @Navigate.started += instance.OnNavigate;
                    @Navigate.performed += instance.OnNavigate;
                    @Navigate.canceled += instance.OnNavigate;
                    @Submit.started += instance.OnSubmit;
                    @Submit.performed += instance.OnSubmit;
                    @Submit.canceled += instance.OnSubmit;
                    @Confirm.started += instance.OnConfirm;
                    @Confirm.performed += instance.OnConfirm;
                    @Confirm.canceled += instance.OnConfirm;
                    @Cancel.started += instance.OnCancel;
                    @Cancel.performed += instance.OnCancel;
                    @Cancel.canceled += instance.OnCancel;
                    @MouseMove.started += instance.OnMouseMove;
                    @MouseMove.performed += instance.OnMouseMove;
                    @MouseMove.canceled += instance.OnMouseMove;
                    @Unpause.started += instance.OnUnpause;
                    @Unpause.performed += instance.OnUnpause;
                    @Unpause.canceled += instance.OnUnpause;
                    @ChangeTab.started += instance.OnChangeTab;
                    @ChangeTab.performed += instance.OnChangeTab;
                    @ChangeTab.canceled += instance.OnChangeTab;
                    @InventoryActionButton.started += instance.OnInventoryActionButton;
                    @InventoryActionButton.performed += instance.OnInventoryActionButton;
                    @InventoryActionButton.canceled += instance.OnInventoryActionButton;
                    @SaveActionButton.started += instance.OnSaveActionButton;
                    @SaveActionButton.performed += instance.OnSaveActionButton;
                    @SaveActionButton.canceled += instance.OnSaveActionButton;
                    @ResetActionButton.started += instance.OnResetActionButton;
                    @ResetActionButton.performed += instance.OnResetActionButton;
                    @ResetActionButton.canceled += instance.OnResetActionButton;
                    @Click.started += instance.OnClick;
                    @Click.performed += instance.OnClick;
                    @Click.canceled += instance.OnClick;
                    @Point.started += instance.OnPoint;
                    @Point.performed += instance.OnPoint;
                    @Point.canceled += instance.OnPoint;
                    @RightClick.started += instance.OnRightClick;
                    @RightClick.performed += instance.OnRightClick;
                    @RightClick.canceled += instance.OnRightClick;
                    @CloseInventory.started += instance.OnCloseInventory;
                    @CloseInventory.performed += instance.OnCloseInventory;
                    @CloseInventory.canceled += instance.OnCloseInventory;
                }
            }
        }
        public MenusActions @Menus => new MenusActions(this);

        // Dialogues
        private readonly InputActionMap m_Dialogues;
        private IDialoguesActions m_DialoguesActionsCallbackInterface;
        private readonly InputAction m_Dialogues_MoveSelection;
        private readonly InputAction m_Dialogues_AdvanceDialogue;
        public struct DialoguesActions
        {
            private @GameInput m_Wrapper;
            public DialoguesActions(@GameInput wrapper) { m_Wrapper = wrapper; }
            public InputAction @MoveSelection => m_Wrapper.m_Dialogues_MoveSelection;
            public InputAction @AdvanceDialogue => m_Wrapper.m_Dialogues_AdvanceDialogue;
            public InputActionMap Get() { return m_Wrapper.m_Dialogues; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(DialoguesActions set) { return set.Get(); }
            public void SetCallbacks(IDialoguesActions instance)
            {
                if (m_Wrapper.m_DialoguesActionsCallbackInterface != null)
                {
                    @MoveSelection.started -= m_Wrapper.m_DialoguesActionsCallbackInterface.OnMoveSelection;
                    @MoveSelection.performed -= m_Wrapper.m_DialoguesActionsCallbackInterface.OnMoveSelection;
                    @MoveSelection.canceled -= m_Wrapper.m_DialoguesActionsCallbackInterface.OnMoveSelection;
                    @AdvanceDialogue.started -= m_Wrapper.m_DialoguesActionsCallbackInterface.OnAdvanceDialogue;
                    @AdvanceDialogue.performed -= m_Wrapper.m_DialoguesActionsCallbackInterface.OnAdvanceDialogue;
                    @AdvanceDialogue.canceled -= m_Wrapper.m_DialoguesActionsCallbackInterface.OnAdvanceDialogue;
                }
                m_Wrapper.m_DialoguesActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @MoveSelection.started += instance.OnMoveSelection;
                    @MoveSelection.performed += instance.OnMoveSelection;
                    @MoveSelection.canceled += instance.OnMoveSelection;
                    @AdvanceDialogue.started += instance.OnAdvanceDialogue;
                    @AdvanceDialogue.performed += instance.OnAdvanceDialogue;
                    @AdvanceDialogue.canceled += instance.OnAdvanceDialogue;
                }
            }
        }
        public DialoguesActions @Dialogues => new DialoguesActions(this);

        // Cheats
        private readonly InputActionMap m_Cheats;
        private ICheatsActions m_CheatsActionsCallbackInterface;
        private readonly InputAction m_Cheats_OpenCheatMenu;
        public struct CheatsActions
        {
            private @GameInput m_Wrapper;
            public CheatsActions(@GameInput wrapper) { m_Wrapper = wrapper; }
            public InputAction @OpenCheatMenu => m_Wrapper.m_Cheats_OpenCheatMenu;
            public InputActionMap Get() { return m_Wrapper.m_Cheats; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(CheatsActions set) { return set.Get(); }
            public void SetCallbacks(ICheatsActions instance)
            {
                if (m_Wrapper.m_CheatsActionsCallbackInterface != null)
                {
                    @OpenCheatMenu.started -= m_Wrapper.m_CheatsActionsCallbackInterface.OnOpenCheatMenu;
                    @OpenCheatMenu.performed -= m_Wrapper.m_CheatsActionsCallbackInterface.OnOpenCheatMenu;
                    @OpenCheatMenu.canceled -= m_Wrapper.m_CheatsActionsCallbackInterface.OnOpenCheatMenu;
                }
                m_Wrapper.m_CheatsActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @OpenCheatMenu.started += instance.OnOpenCheatMenu;
                    @OpenCheatMenu.performed += instance.OnOpenCheatMenu;
                    @OpenCheatMenu.canceled += instance.OnOpenCheatMenu;
                }
            }
        }
        public CheatsActions @Cheats => new CheatsActions(this);
        private int m_MouseAndKeyboardSchemeIndex = -1;
        public InputControlScheme MouseAndKeyboardScheme
        {
            get
            {
                if (m_MouseAndKeyboardSchemeIndex == -1) m_MouseAndKeyboardSchemeIndex = asset.FindControlSchemeIndex("MouseAndKeyboard");
                return asset.controlSchemes[m_MouseAndKeyboardSchemeIndex];
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
        public interface IGameplayActions
        {
            void OnMove(InputAction.CallbackContext context);
            void OnAttack(InputAction.CallbackContext context);
            void OnInteract(InputAction.CallbackContext context);
            void OnPause(InputAction.CallbackContext context);
            void OnOpenInventory(InputAction.CallbackContext context);
            void OnDash(InputAction.CallbackContext context);
        }
        public interface IMenusActions
        {
            void OnMoveSelection(InputAction.CallbackContext context);
            void OnNavigate(InputAction.CallbackContext context);
            void OnSubmit(InputAction.CallbackContext context);
            void OnConfirm(InputAction.CallbackContext context);
            void OnCancel(InputAction.CallbackContext context);
            void OnMouseMove(InputAction.CallbackContext context);
            void OnUnpause(InputAction.CallbackContext context);
            void OnChangeTab(InputAction.CallbackContext context);
            void OnInventoryActionButton(InputAction.CallbackContext context);
            void OnSaveActionButton(InputAction.CallbackContext context);
            void OnResetActionButton(InputAction.CallbackContext context);
            void OnClick(InputAction.CallbackContext context);
            void OnPoint(InputAction.CallbackContext context);
            void OnRightClick(InputAction.CallbackContext context);
            void OnCloseInventory(InputAction.CallbackContext context);
        }
        public interface IDialoguesActions
        {
            void OnMoveSelection(InputAction.CallbackContext context);
            void OnAdvanceDialogue(InputAction.CallbackContext context);
        }
        public interface ICheatsActions
        {
            void OnOpenCheatMenu(InputAction.CallbackContext context);
        }
    }
}