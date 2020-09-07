# LidarSimulationUsingUnityROS
Simulating a LIDAR in unity and publishing that data on a ROS topic

The above scripts facilitate the simulation of a LIDAR in Unity, and then publishing the distance array of the lidar on a ROS topic.

The lidar script uses Raycast feature of Unity Game Engine.
The distance array, of float type, consists of 360 members, the ith member storing the distance at which the ray hit an object at the ith degree.

The distance array is published on a ROS topic using a unity asset ROS#.
Using ROS_Bridge_Websocket of the ROS_Bridge_server package we can publish data from Unity on a ROS topic.
