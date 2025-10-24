using System;
using Coral.Managed.Interop;

#pragma warning disable CS0649

namespace Strype
{
    internal static unsafe class InternalCalls
    {
        internal static delegate* unmanaged<float, float, ulong, uint> Room_CreateObject;
        internal static delegate* unmanaged<uint, void> Room_DestroyObject;
        internal static delegate* unmanaged<NativeString, void> Room_TransitionRoom
        internal static delegate* unmanaged<Vector2*, void> Camera_Move;
        internal static delegate* unmanaged<float*, void> Camera_Zoom;

        internal static delegate* unmanaged<NativeString, void> Audio_PlaySound;
        internal static delegate* unmanaged<NativeString, Vector2*, void> Audio_PlaySoundOn;

        internal static delegate* unmanaged<uint, Vector2*, void> Object_GetPosition;
        internal static delegate* unmanaged<uint, Vector2*, void> Object_SetPosition;
        internal static delegate* unmanaged<uint, float*, void> Object_GetRotation;
        internal static delegate* unmanaged<uint, float*, void> Object_SetRotation;
        internal static delegate* unmanaged<uint, Vector2*, void> Object_GetScale;
        internal static delegate* unmanaged<uint, Vector2*, void> Object_SetScale;
        
        internal static delegate* unmanaged<NativeString, Bool32> Input_IsVerbPressed;
        internal static delegate* unmanaged<NativeString, Bool32> Input_IsVerbHeld;
        internal static delegate* unmanaged<NativeString, Bool32> Input_IsVerbDown;
        internal static delegate* unmanaged<NativeString, Bool32> Input_IsVerbReleased;

        internal static delegate* unmanaged<KeyCode, Bool32> Input_IsKeyPressed;
        internal static delegate* unmanaged<KeyCode, Bool32> Input_IsKeyHeld;
        internal static delegate* unmanaged<KeyCode, Bool32> Input_IsKeyDown;
        internal static delegate* unmanaged<KeyCode, Bool32> Input_IsKeyReleased;
        internal static delegate* unmanaged<MouseButton, bool> Input_IsMouseButtonPressed;
        internal static delegate* unmanaged<MouseButton, bool> Input_IsMouseButtonHeld;
        internal static delegate* unmanaged<MouseButton, bool> Input_IsMouseButtonDown;
        internal static delegate* unmanaged<MouseButton, bool> Input_IsMouseButtonReleased;
        internal static delegate* unmanaged<Vector2*, void> Input_GetMousePosition;

        internal static delegate* unmanaged<Log.LogLevel, NativeString, void> Log_LogMessage;
    }
}

#pragma warning restore CS0649