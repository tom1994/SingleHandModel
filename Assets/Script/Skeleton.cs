using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
namespace Assets.Script
{
    public enum HandType
    {
        Right,
        Left
    }

    public enum ModelType
    {
        HandOnly,
        HandArm,
        Body
    }

    public enum JointType
    {
        Hand,
        Thumb_1,
        Thumb_2,
        Thumb_3,
        Index_1,
        Index_2,
        Index_3,
        Middle_1,
        Middle_2,
        Middle_3,
        Ring_1,
        Ring_2,
        Ring_3,
        Little_1,
        Little_2,
        Little_3,
        ForeArm,
        MiddleArm,
        UpperArm
    }

    public static class Definition
    {
        public static int SENSOR_COUNT = 14;
        public static int JOINT_COUNT = 19;
        public static int BONE_COUNT = 21;
    }

    public class SimpleJoint
    {
        public JointType Type { get; set; }
        public float W { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }

        public SimpleJoint() { }

        public SimpleJoint(JointType type)
        {
            Type = type;
            W = 1;
            X = 0;
            Y = 0;
            Z = 0;
        }

        public SimpleJoint(JointType type, Quaternion q)
        {
            Type = type;
            W = q.w;
            X = q.x;
            Y = q.y;
            Z = q.z;
        }


        public void SetData(Quaternion quat)
        {
            W = quat.w;
            X = quat.x;
            Y = quat.y;
            Z = quat.z;

        }

        public Quaternion ToQuaternion()
        {
            return new Quaternion(X, Y, Z, W);
        }
    }


    public class SkeletonJson
    {
        public HandType Type { get; set; }
        public SimpleJoint[] Joints { get; set; }
    }
}
