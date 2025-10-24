using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Strype
{
    public class Camera
    {
        public static void Move(Vector2 pos)
        {
            unsafe { InternalCalls.Camera_Move(&pos); }
        }

        public static void Zoom(float zoomlevel)
        {
            unsafe { InternalCalls.Camera_Zoom(&zoomlevel); }
        }
    }

    public class Room
    {
        public static Object CreateObject(float x, float y, Object obj)
        {
            unsafe { return new Object(InternalCalls.Room_CreateObject(x, y, obj.Handle), obj.Handle); }
        }

        public static void DestroyObject(Object obj)
        {
            if (obj == null)
                return;

            unsafe { InternalCalls.Room_DestroyObject(obj.ID); }
        }

        public static void TransitionRoom(string room)
        {
            unsafe { InternalCalls.Room_TransitionRoom(room); }
        }

        public static T GetManager<T>() where T : Manager
        {
            unsafe {
                IntPtr handle = InternalCalls.Room_GetManager(typeof(T).Name);
                return (T)GCHandle.FromIntPtr(handle).Target!;
            }
        }


    }
}