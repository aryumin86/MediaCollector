using System;
using System.Collections.Generic;
using System.Text;
using Lib.Entities;
using Lib.TheTasks;

namespace Collector.Collectors
{
    public abstract class ISMCollector
    {
        public void SavePubclications(IEnumerable<SMPublication> publications){
            throw new NotImplementedException();
        }

        public abstract void SubscribeToTasks();

        public abstract IEnumerable<SMPublication> Collect(SMCollectionTask collectionTask);
    }
}