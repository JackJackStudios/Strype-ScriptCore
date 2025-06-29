using Coral.Managed.Interop;
using System;

namespace Strype
{
    public class Object
    {
        internal Object(UInt32 id, UInt64 assetH) => ID = id;

        public readonly UInt32 ID;
        public readonly UInt64 Handle;

        protected virtual void OnCreate() { }
        protected virtual void OnUpdate(float ts) { }
        protected virtual void OnDestroy() { }

        public void Destroy(Object other) => Room.DestroyObject(other);

        public Vector2 Position
        {
            get
            {
                Vector2 result;
                unsafe { InternalCalls.Object_GetPosition(ID, &result); }
                return result;
            }

            set
            {
                unsafe { InternalCalls.Object_SetPosition(ID, &value); }
            }
        }

        public Vector2 Scale
        {
            get
            {
                Vector2 result;
                unsafe { InternalCalls.Object_GetScale(ID, &result); }
                return result;
            }

            set
            {
                unsafe { InternalCalls.Object_SetScale(ID, &value); }
            }
        }

        public float Rotation
        {
            get
            {
                float result;
                unsafe { InternalCalls.Object_GetRotation(ID, &result); }
                return result;
            }

            set
            {
                unsafe { InternalCalls.Object_SetRotation(ID, &value); }
            }
        }
    }
}
