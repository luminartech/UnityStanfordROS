using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Runtime.InteropServices;
using uint8 = System.Byte;
using Messages.geometry_msgs;
using Messages.sensor_msgs;
using Messages.actionlib_msgs;

using Messages.std_msgs;
using String=System.String;

namespace Messages.sensor_msgs
{
#if !TRACE
    [System.Diagnostics.DebuggerStepThrough]
#endif
    public class MultiDOFJointState : IRosMessage
    {

			public Header header; //woo
			public string[] joint_names;
			public Transform[] transforms;
			public Twist[] twist;
			public Wrench[] wrench;


        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public override string MD5Sum() { return "690f272f0640d2631c305eeb8301e59d"; }
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool HasHeader() { return true; }
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool IsMetaType() { return true; }
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public override string MessageDefinition() { return @"Header header
string[] joint_names
geometry_msgs/Transform[] transforms
geometry_msgs/Twist[] twist
geometry_msgs/Wrench[] wrench"; }
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public override MsgTypes msgtype() { return MsgTypes.sensor_msgs__MultiDOFJointState; }
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public override bool IsServiceComponent() { return false; }

        [System.Diagnostics.DebuggerStepThrough]
        public MultiDOFJointState()
        {
            
        }

        [System.Diagnostics.DebuggerStepThrough]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public MultiDOFJointState(byte[] SERIALIZEDSTUFF)
        {
            Deserialize(SERIALIZEDSTUFF);
        }

        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public MultiDOFJointState(byte[] SERIALIZEDSTUFF, ref int currentIndex)
        {
            Deserialize(SERIALIZEDSTUFF, ref currentIndex);
        }



        [System.Diagnostics.DebuggerStepThrough]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public override void Deserialize(byte[] SERIALIZEDSTUFF, ref int currentIndex)
        {
            int arraylength=-1;
            bool hasmetacomponents = false;
            object __thing;
            int piecesize=0;
            byte[] thischunk, scratch1, scratch2;
            IntPtr h;
            
            //header
            header = new Header(SERIALIZEDSTUFF, ref currentIndex);
            //joint_names
            hasmetacomponents |= false;
            arraylength = BitConverter.ToInt32(SERIALIZEDSTUFF, currentIndex);
            currentIndex += Marshal.SizeOf(typeof(System.Int32));
            if (joint_names == null)
                joint_names = new string[arraylength];
            else
                Array.Resize(ref joint_names, arraylength);
            for (int i=0;i<joint_names.Length; i++) {
                //joint_names[i]
                joint_names[i] = "";
                piecesize = BitConverter.ToInt32(SERIALIZEDSTUFF, currentIndex);
                currentIndex += 4;
                joint_names[i] = Encoding.ASCII.GetString(SERIALIZEDSTUFF, currentIndex, piecesize);
                currentIndex += piecesize;
            }
            //transforms
            hasmetacomponents |= true;
            arraylength = BitConverter.ToInt32(SERIALIZEDSTUFF, currentIndex);
            currentIndex += Marshal.SizeOf(typeof(System.Int32));
            if (transforms == null)
                transforms = new Transform[arraylength];
            else
                Array.Resize(ref transforms, arraylength);
            for (int i=0;i<transforms.Length; i++) {
                //transforms[i]
                transforms[i] = new Transform(SERIALIZEDSTUFF, ref currentIndex);
            }
            //twist
            hasmetacomponents |= true;
            arraylength = BitConverter.ToInt32(SERIALIZEDSTUFF, currentIndex);
            currentIndex += Marshal.SizeOf(typeof(System.Int32));
            if (twist == null)
                twist = new Twist[arraylength];
            else
                Array.Resize(ref twist, arraylength);
            for (int i=0;i<twist.Length; i++) {
                //twist[i]
                twist[i] = new Twist(SERIALIZEDSTUFF, ref currentIndex);
            }
            //wrench
            hasmetacomponents |= true;
            arraylength = BitConverter.ToInt32(SERIALIZEDSTUFF, currentIndex);
            currentIndex += Marshal.SizeOf(typeof(System.Int32));
            if (wrench == null)
                wrench = new Wrench[arraylength];
            else
                Array.Resize(ref wrench, arraylength);
            for (int i=0;i<wrench.Length; i++) {
                //wrench[i]
                wrench[i] = new Wrench(SERIALIZEDSTUFF, ref currentIndex);
            }
        }

        [System.Diagnostics.DebuggerStepThrough]
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        public override byte[] Serialize(bool partofsomethingelse)
        {
            int currentIndex=0, length=0;
            bool hasmetacomponents = false;
            byte[] thischunk, scratch1, scratch2;
            List<byte[]> pieces = new List<byte[]>();
            GCHandle h;
            
            //header
            if (header == null)
                header = new Header();
            pieces.Add(header.Serialize(true));
            //joint_names
            hasmetacomponents |= false;
            if (joint_names == null)
                joint_names = new string[0];
            pieces.Add(BitConverter.GetBytes(joint_names.Length));
            for (int i=0;i<joint_names.Length; i++) {
                //joint_names[i]
                if (joint_names[i] == null)
                    joint_names[i] = "";
                scratch1 = Encoding.ASCII.GetBytes((string)joint_names[i]);
                thischunk = new byte[scratch1.Length + 4];
                scratch2 = BitConverter.GetBytes(scratch1.Length);
                Array.Copy(scratch1, 0, thischunk, 4, scratch1.Length);
                Array.Copy(scratch2, thischunk, 4);
                pieces.Add(thischunk);
            }
            //transforms
            hasmetacomponents |= true;
            if (transforms == null)
                transforms = new Transform[0];
            pieces.Add(BitConverter.GetBytes(transforms.Length));
            for (int i=0;i<transforms.Length; i++) {
                //transforms[i]
                if (transforms[i] == null)
                    transforms[i] = new Transform();
                pieces.Add(transforms[i].Serialize(true));
            }
            //twist
            hasmetacomponents |= true;
            if (twist == null)
                twist = new Twist[0];
            pieces.Add(BitConverter.GetBytes(twist.Length));
            for (int i=0;i<twist.Length; i++) {
                //twist[i]
                if (twist[i] == null)
                    twist[i] = new Twist();
                pieces.Add(twist[i].Serialize(true));
            }
            //wrench
            hasmetacomponents |= true;
            if (wrench == null)
                wrench = new Wrench[0];
            pieces.Add(BitConverter.GetBytes(wrench.Length));
            for (int i=0;i<wrench.Length; i++) {
                //wrench[i]
                if (wrench[i] == null)
                    wrench[i] = new Wrench();
                pieces.Add(wrench[i].Serialize(true));
            }
            //combine every array in pieces into one array and return it
            int __a_b__f = pieces.Sum((__a_b__c)=>__a_b__c.Length);
            int __a_b__e=0;
            byte[] __a_b__d = new byte[__a_b__f];
            foreach(var __p__ in pieces)
            {
                Array.Copy(__p__,0,__a_b__d,__a_b__e,__p__.Length);
                __a_b__e += __p__.Length;
            }
            return __a_b__d;
        }

        public override void Randomize()
        {
            int arraylength=-1;
            Random rand = new Random();
            int strlength;
            byte[] strbuf, myByte;
            
            //header
            header = new Header();
            header.Randomize();
            //joint_names
            arraylength = rand.Next(10);
            if (joint_names == null)
                joint_names = new string[arraylength];
            else
                Array.Resize(ref joint_names, arraylength);
            for (int i=0;i<joint_names.Length; i++) {
                //joint_names[i]
                strlength = rand.Next(100) + 1;
                strbuf = new byte[strlength];
                rand.NextBytes(strbuf);  //fill the whole buffer with random bytes
                for (int __x__ = 0; __x__ < strlength; __x__++)
                    if (strbuf[__x__] == 0) //replace null chars with non-null random ones
                        strbuf[__x__] = (byte)(rand.Next(254) + 1);
                strbuf[strlength - 1] = 0; //null terminate
                joint_names[i] = Encoding.ASCII.GetString(strbuf);
            }
            //transforms
            arraylength = rand.Next(10);
            if (transforms == null)
                transforms = new Transform[arraylength];
            else
                Array.Resize(ref transforms, arraylength);
            for (int i=0;i<transforms.Length; i++) {
                //transforms[i]
                transforms[i] = new Transform();
                transforms[i].Randomize();
            }
            //twist
            arraylength = rand.Next(10);
            if (twist == null)
                twist = new Twist[arraylength];
            else
                Array.Resize(ref twist, arraylength);
            for (int i=0;i<twist.Length; i++) {
                //twist[i]
                twist[i] = new Twist();
                twist[i].Randomize();
            }
            //wrench
            arraylength = rand.Next(10);
            if (wrench == null)
                wrench = new Wrench[arraylength];
            else
                Array.Resize(ref wrench, arraylength);
            for (int i=0;i<wrench.Length; i++) {
                //wrench[i]
                wrench[i] = new Wrench();
                wrench[i].Randomize();
            }
        }

        public override bool Equals(IRosMessage ____other)
        {
            if (____other == null) return false;
            bool ret = true;
            sensor_msgs.MultiDOFJointState other = (Messages.sensor_msgs.MultiDOFJointState)____other;

            ret &= header.Equals(other.header);
            if (joint_names.Length != other.joint_names.Length)
                return false;
            for (int __i__=0; __i__ < joint_names.Length; __i__++)
            {
                ret &= joint_names[__i__] == other.joint_names[__i__];
            }
            if (transforms.Length != other.transforms.Length)
                return false;
            for (int __i__=0; __i__ < transforms.Length; __i__++)
            {
                ret &= transforms[__i__].Equals(other.transforms[__i__]);
            }
            if (twist.Length != other.twist.Length)
                return false;
            for (int __i__=0; __i__ < twist.Length; __i__++)
            {
                ret &= twist[__i__].Equals(other.twist[__i__]);
            }
            if (wrench.Length != other.wrench.Length)
                return false;
            for (int __i__=0; __i__ < wrench.Length; __i__++)
            {
                ret &= wrench[__i__].Equals(other.wrench[__i__]);
            }
            // for each SingleType st:
            //    ret &= {st.Name} == other.{st.Name};
            return ret;
        }
    }
}
