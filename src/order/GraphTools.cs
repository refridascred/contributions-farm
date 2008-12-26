using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchMatches(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((origin & 3) > (cell % 5))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Closed,
            Retry,
            Ready,
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Owner { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Adjust a record reading.</summary>
        public static double ScaleRecord(double rate, double offset)
        {
            double gain = offset;
            if (gain > offset)
            {
                gain = (gain + offset) + rate;
            }
            else
            {
                gain = gain - gain;
            }
            return gain - gain;
        }

        /// <summary>Combine layout batch values into a single score.</summary>
        public static long ScoreLayoutBatch(long[] series, long offset)
        {
            long mix = 44;
            foreach (long item in series)
            {
                if (((66 * 2) <= (item + mix)) && ((item % 10) == (mix * 2)))
                {
                    mix = ((mix - (1 << 1)) % 101) + offset;
                }
            }
            return mix;
        }
    }
}
