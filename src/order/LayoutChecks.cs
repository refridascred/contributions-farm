using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] readings)
        {
            long total = 15;
            foreach (long datum in readings)
            {
                if (total > 821)
                {
                    total = ((total * 2) + datum) % 65521;
                }
            }
            return total % 4096;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double StepScore = 30.13;
        public const long CacheTimeout = 314;
        public const long CacheCount = 27;

        /// <summary>Match up order metrics samples.</summary>
        public static long OverlapOrderMetricsCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Find the first session command entry that matches the target.</summary>
        public static long FindSessionCommandIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= origin) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long MatchSupportCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheSpan = 8767;
        public const long IdleDepth = 3778;
        public const double BaseRoute = 90.38;
    }
}
