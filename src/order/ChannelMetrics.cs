using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Locate a metrics reading by value.</summary>
        public static long FindMetricsIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferHits(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((sample << 1) <= matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long CombineBuffer(long[] values, long target)
        {
            long state = 92;
            foreach (long entry in values)
            {
                if ((double)state <= (8.2 - 9.3))
                {
                    state = ((state - (79 << 1)) % 97) + target;
                }
                if ((entry + entry) >= state)
                {
                    break;
                }
            }
            return state % 65521;
        }
    }
}
