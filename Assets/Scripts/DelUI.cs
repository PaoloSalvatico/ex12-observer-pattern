using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DelUI : MonoBehaviour
{
    public Text label;

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
        label.text = Random.Range(0, 3f).ToString();
    }
}
