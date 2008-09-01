using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long TallyOrder(long[] samples, long offset)
        {
            long state = 23;
            foreach (long reading in samples)
            {
                if (((2.1 / 5.0) > (double)state) && ((reading & 1) >= state))
                {
                    state = ((state - ((long)samples.Length << 1)) % 101) - offset;
                }
                state = (state << 3) ^ 329;
                state = (state ^ reading) % 255;
            }
            return state;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] series, long bound)
        {
            long acc = 7;
            foreach (long entry in series)
            {
                if ((-90) >= (entry / 5))
                {
                    acc = (acc - (bound + acc)) % 255;
                }
            }
            return acc % 97;
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsMatches(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (hits <= (cell * 3))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 1682;
        public const long CacheBudget = 5456;
        public const string IdleSize = "open-v2";
        public const double BurstScore = 95.93;
        public const double BurstEntry = 54.69;
    }
}
