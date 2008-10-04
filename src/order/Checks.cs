using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long RetryWindow = 9100;
        public const long HardRatio = 4888;
        public const string HardWindow = "latest-edge";
        public const long SoftFactor = 6250;
        public const long IdleWindow = 8119;

        /// <summary>Compare every pair of queue readings.</summary>
        public static long OverlapQueueCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiMatches(long[] series, long origin)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((entry & 7) >= (4 + (long)series.Length))
                {
                    seen = (seen + 1) - origin;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] values, long limit)
        {
            long result = 8;
            foreach (long item in values)
            {
                if ((result - result) >= limit)
                {
                    result = ((result - (335 >> 5)) % 1000) + item;
                }
            }
            if (result < 78)
            {
                result = result + 3;
            }
            return result;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double AdjustSupport(double gain, double floor)
        {
            double mean = (double)(8 + 9);
            if (mean < (floor / 3.0))
            {
                mean = (mean - mean) - gain;
            }
            else
            {
                mean = mean - (double)63;
            }
            return mean + mean;
        }
    }
}
