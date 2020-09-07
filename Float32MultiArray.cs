/*
This message class is generated automatically with 'SimpleMessageGenerator' of ROS#
*/ 

using Newtonsoft.Json;
using RosSharp.RosBridgeClient.Messages.Geometry;
using RosSharp.RosBridgeClient.Messages.Navigation;
using RosSharp.RosBridgeClient.Messages.Sensor;
using RosSharp.RosBridgeClient.Messages.Standard;
using RosSharp.RosBridgeClient.Messages.Actionlib;

namespace RosSharp.RosBridgeClient.Messages
{
	public class Float32MultiArray : Message
	{
		[JsonIgnore]
		public const string RosMessageName = "std_msgs/Float32MultiArray";

		public float[] data;

		public Float32MultiArray()
		{
			data = new float[0];
		}
	}
}

