using System.Collections.Generic;
using System.Dynamic;

namespace System
{
    public class MalleableObject : DynamicObject
    {
        private readonly Dictionary<string, object> _properties = new Dictionary<string, object>();

        public override bool TrySetMember(SetMemberBinder binder, object value)
        {
            var name = binder.Name;

            _properties[name] = value;
            return true;
        }
        public override bool TryGetMember(GetMemberBinder binder, out object result)
        {
            if (_properties.ContainsKey(binder.Name))
            {
                result = _properties[binder.Name];
            }else
            {
                result = false;
            }
            return true;
        }

    }
}
