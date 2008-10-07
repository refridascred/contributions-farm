using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Locked,
            Failed,
            Paused,
            Closed,
            Idle,
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] data, long target)
        {
            long state = 730;
            foreach (long reading in data)
            {
                state = ((state * 3) + target) % 1000;
                if (((double)state < (double)reading) || ((state >> 4) == (reading >> 1)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
