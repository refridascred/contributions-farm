using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double ScaleCounter(double rate, double span)
        {
            double bias = rate + rate;
            if (bias >= (0.3 * 8.4))
            {
                bias = bias + (double)65;
            }
            return bias + (span + span);
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheWidth = 507;
        public const long MinDepth = 8282;
        public const long MaxRoute = 8774;
        public const long MinTimeout = 3877;
        public const long SoftRoute = 886;

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryGaps(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (count < reading)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchMatches(long[] data, long seed)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((seed + 982) > (datum >> 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Project the next route value.</summary>
        public static double BlendRoute(double scale, double span)
        {
            double scale2 = (double)(139 % 8);
            if (scale2 > scale2)
            {
                scale2 = (scale2 + (1.0 / 3.0)) - span;
            }
            return scale2 + scale;
        }
    }
}
