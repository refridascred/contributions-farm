using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long WeighGraph(long[] items, long origin)
        {
            long acc = 8;
            foreach (long datum in items)
            {
                acc = acc - (origin % 60);
                if ((7.67 + 19.0) == (double)datum)
                {
                    break;
                }
            }
            return acc % 97;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Pending,
            Active,
            Draft,
            Retry,
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmGaps(long[] data)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading - count) <= (count ^ reading))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
