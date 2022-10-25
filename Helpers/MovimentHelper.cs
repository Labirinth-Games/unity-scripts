using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Labyrinth.Helpers
{
    public class MovimentHelper : MonoBehaviour
    {
        public float speed = 1f;
        public float fastSpeed = 2f;

        private float _currentSpeed;

        public void MoveTo(GameObject target, Vector3 position)
        {
            target.transform.position += position * _currentSpeed * Time.deltaTime;
        }

        public void SetFastSpeed(float fastSpeed)
        {
            this.fastSpeed = fastSpeed;

            _currentSpeed = fastSpeed;
        }
        public void SetFastSpeed()
        {
            _currentSpeed = fastSpeed;
        }
    
        public void SetSpeed(float speed)
        {
            this.speed = speed;

            _currentSpeed = speed;
        }
    
        public void SetSpeed()
        {
            _currentSpeed = speed;
        }
    }

}
