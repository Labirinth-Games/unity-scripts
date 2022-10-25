using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Labyrinth.Helpers
{
    public class CameraMoveHelper : MonoBehaviour
    {
        [Header("References")]
        public GameObject person;

        [Header("Settings")]
        public bool lockMouse = false;
        public float sensibility = 2f;

        private float _mouseX = 0f;
        private float _mouseY = 0f;

        public void IsLockMouse()
        {
            if (!lockMouse) return;

            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
        }


        #region --- Unity Events ---
        private void Start()
        {
            IsLockMouse();
        }

        private void Update()
        {
            _mouseX += Input.GetAxis("Mouse X") * sensibility;
            _mouseY -= Input.GetAxis("Mouse Y") * sensibility;

            var eulerAngles = new Vector3(_mouseY, _mouseX, 0);

            transform.eulerAngles = eulerAngles;
            person.transform.eulerAngles = eulerAngles;
        }
        #endregion
    }
}
