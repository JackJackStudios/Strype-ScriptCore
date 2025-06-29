using System;

namespace Strype
{

    public static class Input
    {
        public static bool IsKeyPressed(KeyCode keycode)
        {
            unsafe { return InternalCalls.Input_IsKeyPressed(keycode); }
        }

        public static bool IsKeyHeld(KeyCode keycode)
        {
            unsafe { return InternalCalls.Input_IsKeyHeld(keycode); }
        }

        public static bool IsKeyDown(KeyCode keycode)
        {
            unsafe { return InternalCalls.Input_IsKeyDown(keycode); }
        }

        public static bool IsKeyReleased(KeyCode keycode)
        {
            unsafe { return InternalCalls.Input_IsKeyReleased(keycode); }
        }

        public static bool IsMouseButtonPressed(MouseButton button)
        {
            unsafe { return InternalCalls.Input_IsMouseButtonPressed(button); }
        }

        public static bool IsMouseButtonHeld(MouseButton button)
        {
            unsafe { return InternalCalls.Input_IsMouseButtonHeld(button); }
        }

        public static bool IsMouseButtonDown(MouseButton button)
        {
            unsafe { return InternalCalls.Input_IsMouseButtonDown(button); }
        }

        public static bool IsMouseButtonReleased(MouseButton button)
        {
            unsafe { return InternalCalls.Input_IsMouseButtonReleased(button); }
        }

        public static Vector2 GetMousePosition()
        {
            Vector2 position;
            unsafe { InternalCalls.Input_GetMousePosition(&position); }
            return position;
        }
    }

}