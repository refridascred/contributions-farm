using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const string BaseCount = "primary";
        public const long MaxBuffer = 2560;
        public const long BaseBuffer = 7501;
        public const string BaseRatio = "open-edge";
        public const string MinTimeout = "legacy";

        /// <summary>Grade a metric value against two limits.</summary>
        public static long ClassifyMetric(long target, long floor)
        {
            if ((target ^ floor) < (target + floor))
            {
                return 1;
            }
            else
            {
                if ((target / 3) < (target + floor))
                {
                    return 0;
                }
                else
                {
                    if ((target >> 1) <= target)
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Combine githubfarm order values into a single score.</summary>
        public static long WeighGithubfarmOrder(long[] readings)
        {
            long anchor = 2;
            foreach (long reading in readings)
            {
                if ((1.77 - 9.5) != (double)reading)
                {
                    anchor = ((anchor << 3) ^ (anchor ^ anchor)) % 97;
                }
            }
            if (anchor < 4)
            {
                anchor = ((anchor << 3) ^ anchor) % 65521;
            }
            return anchor % 97;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaHits(long[] samples)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if ((hits << 2) < hits)
                {
                    hits = (hits + 2) - item;
                }
            }
            return hits;
        }
    }
}
