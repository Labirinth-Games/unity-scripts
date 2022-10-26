using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Labyrinth.Core
{
    public class SubscribeEventCalback
    {
        private Action _onEvent;
        private Action _callback;

        public void Subscribe(Action onEvent, Action callback)
        {
            this._onEvent = onEvent;
            this._callback = callback;

            _onEvent += _callback;
        }

        public void UnSubscribe()
        {
            if (_onEvent != null)
                _onEvent -= _callback;
        }
    }
}
