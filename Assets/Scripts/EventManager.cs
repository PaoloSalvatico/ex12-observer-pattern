using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : Singleton<EventManager>
{
    public delegate void DoSomething();
    public DoSomething OnDoSomething;

    public void ExecuteDoSomething()
    {
        if(OnDoSomething != null) OnDoSomething();
    }
}
