using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelPlayer : MonoBehaviour
{
    private void OnEnable()
    {
        EventManager.Instance.OnDoSomething += PlayerDoSomenthing;
    }

    private void OnDisable()
    {
        EventManager.Instance.OnDoSomething -= PlayerDoSomenthing;
    }

    protected void PlayerDoSomenthing()
    {
        Debug.Log("Player DoSomething eseguito da " + gameObject.name);
    }
}
