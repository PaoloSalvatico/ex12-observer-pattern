using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IObserver
{
    void Changed();
    void Destroy(float delay);
}
