using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Level { get; set; }
            public double Size { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Look up the position of a queue account sample.</summary>
        public static long SeekQueueAccountIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= step) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long MeasureContributiMatches(long[] items)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (seen >= (744 & 7))
                {
                    seen = (seen + 3) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LookupOrderIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= target) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
