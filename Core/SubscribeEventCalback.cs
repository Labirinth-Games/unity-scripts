using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubscribeEventCalback : MonoBehaviour
{
    private Action _onEvent;
    private AsyncCallback _callback;

    public void Subscriber(Action onEvent, AsyncCallback callback)
    {
        this._onEvent = onEvent;
        this._callback = callback;
    }

    void Start()
    {
        //if (_onEvent != null)
        //    _onEvent += _callback;
    }

    private void OnDestroy()
    {
        //if (_onEvent != null)
        //    _onEvent -= _callback;
    }
}
