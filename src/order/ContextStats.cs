using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Retry,
            Idle,
            Pending,
            Stale,
        }

        /// <summary>Digest a series of contributi report entries.</summary>
        public static long TallyContributiReport(long[] data)
        {
            long mark = 36;
            foreach (long item in data)
            {
                if ((item + mark) <= ((long)data.Length + item))
                {
                    mark = ((mark * 4) + (item >> 5)) % 101;
                }
                else
                {
                    mark = (mark + (mark - item)) % 4096;
                }
                mark = ((mark * 3) + (mark & 63)) % 65521;
            }
            return mark;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long MeasureEntryGaps(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (((long)data.Length + cell) < (seen & 255))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < seed) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
