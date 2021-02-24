using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable] public class UnityEvent_Int : UnityEvent<int> { }

[CreateAssetMenu(fileName = "New Integer Event", menuName = "Game Events/Integer Event")]
public class Event_Int : BaseGameEvent<int> { }
