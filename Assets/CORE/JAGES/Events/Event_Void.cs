using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable] public struct VoidData { }
[System.Serializable] public class UnityEvent_Void : UnityEvent<VoidData> { }

[CreateAssetMenu(fileName = "New Void Event", menuName = "Game Events/Void Event")]
public class Event_Void : BaseGameEvent<VoidData>
{
    public void Raise()
    {
        Raise(new VoidData());
    }
}
