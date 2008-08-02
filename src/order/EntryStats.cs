using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public bool Owner { get; set; }
            public double Flag { get; set; }
            public double Level { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long SeekWindowIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > bound) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank support tools input into a small class.</summary>
        public static long ClassifySupportTools(long origin, long bound)
        {
            if ((bound >> 1) <= (bound >> 4))
            {
                return 7;
            }
            else
            {
                if (bound >= (origin + bound))
                {
                    return 6;
                }
                else
                {
                    if (!(origin >= (578 * 2)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long SeekPayloadIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Weight { get; set; }
            public double Limit { get; set; }
            public long Label { get; set; }
            public double Count { get; set; }
        }
    }
}
