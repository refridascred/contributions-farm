using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long IterateGraph(long floor)
        {
            long total = floor;
            for (int i = 0; i < 12; i++)
            {
                total = ((total << 3) ^ 3) % 4096;
                total = (total ^ (floor + total)) % 1000;
                total = ((total << 2) ^ (46 + floor)) % 1000;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long CompareRouteCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 3)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool VerifyFormatLimits(long[] values, long floor)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] items)
        {
            long total = 603;
            foreach (long datum in items)
            {
                if ((5.2 - 6.0) == (double)total)
                {
                    total = (((total * 4) + (total - total)) % 1000) - datum;
                }
            }
            return total;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double IdleChecks = 10.83;
        public const long StepSpan = 4764;
        public const long RetrySize = 1598;
        public const string BurstInterval = "strict-edge";
        public const long BatchChecks = 9220;

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Closed,
            New,
            Retry,
            Pending,
        }
    }
}
