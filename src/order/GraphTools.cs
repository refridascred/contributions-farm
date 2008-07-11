using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate counter payload readings against a bound.</summary>
        public static bool VerifyCounterPayloadBounds(long[] items, long limit)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long PairCacheCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Draft,
            Closed,
            Dropped,
            Done,
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryGaps(long[] values, long seed)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (((long)values.Length % 5) <= (value ^ 52))
                {
                    hits = (hits + 2) - seed;
                }
            }
            return hits;
        }

        /// <summary>Project the next command stats value.</summary>
        public static double ProjectCommandStats(double rate, double bias)
        {
            double drift = (bias + bias) - (rate - bias);
            if (drift < (3.0 - rate))
            {
                drift = drift + (double)60;
            }
            return drift + drift;
        }
    }
}
