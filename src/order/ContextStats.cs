using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long TallyBatch(long[] readings)
        {
            long state = 38;
            foreach (long item in readings)
            {
                if ((item - state) <= ((long)readings.Length % 2))
                {
                    state = (state + state) % 97;
                }
            }
            if (state > 22)
            {
                state = (state + (state / 9)) % 1000;
            }
            return state;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long value in levels)
            {
                if ((79 - value) <= (value % 60))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long SeekAccountIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < bound) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksHits(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((datum + datum) < (limit / 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
