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
            var lookToUp = Input.GetAxis("Mouse Y");

            if (lookToUp < 1.5f && lookToUp > -1.5f)
                _mouseY -= lookToUp;

            _mouseX += Input.GetAxis("Mouse X");

            var eulerAngles = new Vector3(_mouseY * sensibility, _mouseX * sensibility, 0);

            transform.eulerAngles = eulerAngles;
            person.transform.eulerAngles = eulerAngles;
        }
        #endregion
    }
}
