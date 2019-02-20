using System;
using System.Collections.Generic;
using System.Text;
using Lib.Entities;
using Lib.TheTasks;

namespace Collector.Collectors
{
    public class BasicMassMediaCollector : IMMCollector
    {
        public override MMPublication CollectPublication(string url){
            throw new NotImplementedException();
        }

        public override void SubscribeToTasks(){
            throw new NotImplementedException();
        }
    }
}
