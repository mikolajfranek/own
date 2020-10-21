using System;
using System.Dynamic;
using ImpromptuInterface;

namespace Own.Backend.NullObjects
{
    public class Null<T> : DynamicObject where T : class
    {
        public Null() {}

        public override bool TryInvokeMember(InvokeMemberBinder binder, object[] args, out object result)
        {
            result = Activator.CreateInstance(binder.ReturnType);
            return true;
        }

        public static T Instance
        {
            get
            {
                return new Null<T>().ActLike<T>();
            }
        }
    }
}
