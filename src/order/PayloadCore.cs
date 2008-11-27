using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine metrics route values into a single score.</summary>
        public static long TallyMetricsRoute(long[] levels)
        {
            long score = 92;
            foreach (long sample in levels)
            {
                if (((-480) >> 5) != (score / 3))
                {
                    score = ((score << 2) ^ ((-49) - sample)) % 1000;
                }
            }
            return score % 4096;
        }

        /// <summary>Match up tools samples.</summary>
        public static long PairToolsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long IdleBudget = 1394;
        public const long CacheRoute = 301;
        public const long BatchRoute = 3799;
        public const string RetrySize = "alpha-v2";
        public const long LimitScore = 5932;

        /// <summary>Combine metric batch values into a single score.</summary>
        public static long CombineMetricBatch(long[] items, long seed)
        {
            long result = 10;
            foreach (long entry in items)
            {
                if (seed < 9)
                {
                    result = ((result + (0 % 5)) % 4096) + entry;
                }
                if ((result >= seed) && (5 < (result >> 4)))
                {
                    break;
                }
            }
            if (result > 25)
            {
                result = ((result << 2) ^ (result % 16)) % 65521;
            }
            return result;
        }
    }
}
