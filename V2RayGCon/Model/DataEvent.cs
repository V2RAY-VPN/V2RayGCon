﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace V2RayGCon.Model
{
    class DataEvent : EventArgs
    {
        public string Data;
        public DataEvent(string data)
        {
            Data = data;
        }

    }
}