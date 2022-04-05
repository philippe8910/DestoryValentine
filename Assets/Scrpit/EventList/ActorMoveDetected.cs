using UnityEngine;

namespace Scrpit.EventList
{
    public class ActorMoveDetected
    {
        public Vector3 direction;

        public ActorMoveDetected(Vector3 _direction)
        {
            direction = _direction;
        }
    }
}