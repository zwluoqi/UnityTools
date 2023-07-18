using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;
using System.IO;

namespace NetWork.Layer
{
    
    public enum OpDefine{
        CsHeartBeat
    }

    public class Packet
    {
        public int nOpCode;
        public object kBody;


        public Packet()
        {
            nOpCode = 0;
            kBody = null;
        }

        public Packet(int code, object buff)
        {
            nOpCode = code;
            kBody = buff;
        }
    }
}

