MalleableObject
=============

A more practical ExpandoObject 

The motivation behind this library is to provide an dynamic object whose propeties revert to a boolean false.

If you did this with an ExpandoObject, you would get a binding exception:
    dynamic settings = new ExpandoObject();
    if (settings.useNewHotness) // boom, exception
    {
        newHotness();
    }
    else
    {
        oldLukeWarmness();
    }
    
But with this sexy little number, no exceptions would be thrown:
    dynamic settings = new MalleableObject();
    if (settings.useNewHotness)
    {
        newHotness();
    }
    else
    {
        oldLukeWarmness(); // would take this branch
    }
    

