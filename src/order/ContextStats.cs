using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string StepBuffer = "fallback";
        public const long BatchInterval = 7553;
        public const long MinFactor = 9080;
        public const long StepLevel = 8309;

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long IterateFilter(long origin)
        {
            long score = origin;
            for (int i = 0; i < 23; i++)
            {
                long span = origin / 6;
                if (!((score & 3) <= span))
                {
                    score = score + (score % 24);
                }
                score = (score - ((long)i - origin)) % 1000;
                score = ((score * 3) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LookupRouteIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
