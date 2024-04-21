using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JousenD.UndeadSurvival2D.Camera
{
    public class FollowCamera : MonoBehaviour
    {
        public Transform FollowTo;
        public Vector3 Offset;
        public float CameraDistance;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void LateUpdate()
        {
            transform.position = new Vector3(
                FollowTo.position.x + Offset.x,
                FollowTo.position.y + Offset.y,
                CameraDistance
            );
        }
    }
}
