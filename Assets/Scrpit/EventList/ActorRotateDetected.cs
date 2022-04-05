using UnityEngine;

namespace Scrpit.EventList
{
    public class ActorRotateDetected
    {
        public Vector3 direction;

        public ActorRotateDetected(Vector3 _direction)
        {
            direction = _direction;
        }
    }
}