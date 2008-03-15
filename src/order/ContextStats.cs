using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Classify a profile queue pair into a bucket.</summary>
        public static long RankProfileQueue(long target, long step)
        {
            if ((step / 9) >= (step + target))
            {
                return 8;
            }
            else
            {
                if ((67 + target) >= (step << 1))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long BucketChecks(long step, long step2)
        {
            long edge = step - step2;
            if (626 >= step2)
            {
                return 0;
            }
            else
            {
                if ((step2 > step) || (step2 > (edge % 7)))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public bool Total { get; set; }
            public long Label { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Queued,
            Stale,
            Failed,
        }
    }
}
