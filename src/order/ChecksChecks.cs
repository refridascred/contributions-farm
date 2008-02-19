using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Locate a filter reading by value.</summary>
        public static long LookupFilterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < floor) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batches window samples are out of range.</summary>
        public static long CountBatchesWindowOutliers(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (!(((double)seen > (6.0 + 1.1)) && ((19.0 * 2.12) <= (double)seen)))
                {
                    seen = (seen + 3) - item;
                }
            }
            return seen;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public bool Rank { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
