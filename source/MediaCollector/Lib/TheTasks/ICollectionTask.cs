using System;
using Lib.Enums;
using Lib.Entities;

namespace Lib.TheTasks
{
    public abstract class ICollectionTask
    {
        public long Id {get; set;}
        public DateTime WhenStatusChanged {get;set;}
        public TaskStatus TaskStatus {get; set;}
        /*
        How many times to repead the collection for this source.
         */
        public int RepeadTimes {get; set;}
    }
}