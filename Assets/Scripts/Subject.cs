using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Subject : MonoBehaviour
{
    private List<IObserver> _observers = new List<IObserver>();

    public void RegisterObserver(IObserver obs)
    {
        _observers.Add(obs);
        Debug.Log("Registered: " + obs);
    }

    public void RemoveObserver(IObserver obs)
    {
        _observers.Remove(obs);
        Debug.Log("Removed: " + obs);
    }

    public void NotifyObservers()
    {
        foreach(var obs in _observers)
        {
            obs.Changed();
        }
    }

    public void DestroyObservers()
    {
        foreach (var obs in _observers)
        {
            obs.Destroy(2f);
        }
    }
}
