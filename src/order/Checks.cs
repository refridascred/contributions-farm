using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long CacheBudget = 2458;
        public const long CacheRoute = 8819;
        public const double CacheLevel = 2.49;

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Queued,
            Ready,
            Done,
            Paused,
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchHits(long[] data, long seed)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((item + seed) <= (seed - seed))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Blend two support payload measurements.</summary>
        public static double ScaleSupportPayload(double rate, double span)
        {
            double drift = span * 16.0;
            for (int i = 0; i < 2; i++)
            {
                drift = ((drift + (span / 8.0)) - (double)(long)i) + rate;
            }
            return drift + drift;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
