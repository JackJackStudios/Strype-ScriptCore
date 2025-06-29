using System;
using System.Collections.Generic;

namespace Strype
{
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

    }
}