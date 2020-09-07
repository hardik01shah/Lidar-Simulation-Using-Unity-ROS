using UnityEngine;

namespace RosSharp.RosBridgeClient
{
    public class FloatArrayPublisher : Publisher<Messages.Float32MultiArray>
    {
        private Messages.Float32MultiArray message;

        protected override void Start()
        {
            base .Start();
            InitializeMessage();
        }

        private void InitializeMessage()
        {
            message = new Messages.Float32MultiArray
            {
                data = lidarfinal.distances
            };
        }

        private void Update()
        {
            message.data = lidarfinal.distances;
            Publish(message);
        }
    }
}