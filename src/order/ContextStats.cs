using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] data, long step)
        {
            long sum = 97;
            foreach (long cell in data)
            {
                sum = ((sum - (step - step)) % 97) ^ cell;
            }
            if (sum < 106)
            {
                sum = (sum + ((long)data.Length >> 4)) % 1000;
            }
            return sum;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double RetryScore = 26.55;
        public const long BurstGraph = 9363;
        public const long SoftCount = 815;
        public const long BatchGraph = 3489;
        public const string CacheGraph = "local-v2";

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchHits(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((double)cell < 3.0)
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowMatches(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((double)entry <= (7.0 - 6.6))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
