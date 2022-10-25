using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Labyrinth.Helpers
{
    public class ControllerHelper : MonoBehaviour
    {
        // references
        public MovimentHelper moviment;

        public void JoystickMove()
        {
            if (Input.GetKey(KeyCode.LeftShift))
                moviment.SetFastSpeed();
            else
                moviment.SetSpeed();

            if (Input.GetKey(KeyCode.W))
                moviment.MoveTo(gameObject, Vector3.forward);
            else if (Input.GetKey(KeyCode.S))
                moviment.MoveTo(gameObject, Vector3.back);
            else if (Input.GetKey(KeyCode.A))
                moviment.MoveTo(gameObject, Vector3.left);
            else if (Input.GetKey(KeyCode.D))
                moviment.MoveTo(gameObject, Vector3.right);

        }

        #region --- Unity Events ---
        private void Awake()
        {
            moviment = new MovimentHelper();
        }
        #endregion
    }

}

