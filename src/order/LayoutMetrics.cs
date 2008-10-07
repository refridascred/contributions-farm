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

        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] series, long offset)
        {
            long mark = 8;
            foreach (long item in series)
            {
                if ((mark >> 2) < mark)
                {
                    mark = ((mark - mark) - item) - offset;
                }
            }
            return mark;
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
