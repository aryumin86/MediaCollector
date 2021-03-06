﻿using System;
using System.Collections.Generic;
using System.Text;
using Lib.Entities;
using Lib.TheTasks;

namespace Collector.Collectors
{
    public abstract class IMMCollector
    {
        public void SavePubclications(IEnumerable<MMPublication> publications){
            throw new NotImplementedException();
        }

        public abstract MMPublication CollectPublication(string url);

        public abstract void SubscribeToTasks();
    }
}
