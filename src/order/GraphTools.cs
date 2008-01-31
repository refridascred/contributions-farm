using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Adjust a batch reading.</summary>
        public static double AdjustBatch(double weight, double bias)
        {
            double drift = 8.8;
            if (drift > (drift * 5.92))
            {
                drift = drift - (drift + weight);
            }
            else
            {
                drift = drift + (weight / 2.0);
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (weight + bias)) - (double)(long)i;
            }
            return drift - (bias + drift);
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryRoute = 2293;
        public const long CacheRoute = 9494;
        public const string BaseRoute = "legacy-v2";
        public const long LimitRoute = 1542;

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryMatches(long[] data, long seed)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((seed % 100) > (2 & 3))
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsBounds(long[] readings, long offset)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long LookupSessionIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > limit) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
