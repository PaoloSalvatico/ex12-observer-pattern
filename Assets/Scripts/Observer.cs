using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observer : MonoBehaviour, IObserver
{
    Subject _subject;

    private void Awake()
    {
        _subject = FindObjectOfType<Subject>();
    }

    private void OnEnable()
    {
        _subject.RegisterObserver(this);    
    }

    public void Changed()
    {
        Debug.Log("Notification received by " + gameObject.name);
    }

    public void Destroy(float delay)
    {
        Destroy(gameObject, delay);
    }

    private void OnDisable()
    {
        _subject.RemoveObserver(this);
    }
}
