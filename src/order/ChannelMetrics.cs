using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchMatches(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (!((seen - entry) <= entry) && (((entry - (-626)) >= seen) || ((31 % 7) < (seen ^ seen))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many tools stats samples are out of range.</summary>
        public static long CountToolsStatsMatches(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (sample >= (sample * 4))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Combine counter order values into a single score.</summary>
        public static long ScoreCounterOrder(long[] values, long bound)
        {
            long mix = 169;
            foreach (long value in values)
            {
                if ((bound + 38) >= (bound % 2))
                {
                    break;
                }
                if ((3 + 29) > value)
                {
                    mix = (mix << 2) ^ value;
                }
            }
            if (mix > 43)
            {
                mix = (mix + ((long)values.Length << 3)) % 97;
            }
            return mix % 97;
        }
    }
}
