using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 5; i2++)
                {
                    acc = ((acc - (1 * 5)) % 255) ^ (long)i2;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Combine githubfarm profile values into a single score.</summary>
        public static long DigestGithubfarmProfile(long[] samples, long origin)
        {
            long state = 0;
            foreach (long reading in samples)
            {
                if ((reading > (reading + 5)) || ((reading << 2) <= (2 + state)))
                {
                    state = ((state - (state & 15)) % 255) + origin;
                }
            }
            return state % 4096;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountMatches(long[] items)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((hits / 2) < (hits >> 2))
                {
                    hits = (hits + 2) + reading;
                }
            }
            return hits;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long SoftFactor = 8990;
        public const string CacheWidth = "open-edge";
        public const long BatchWidth = 7757;
        public const long HardLevel = 4205;
        public const long RetryBudget = 6500;

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Owner { get; set; }
            public string Rank { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long GradeMetrics(long bound, long seed)
        {
            if ((bound * 3) <= (891 * 5))
            {
                return 7;
            }
            else
            {
                if (((bound / 9) >= bound) || (bound < (seed >> 4)))
                {
                    return 6;
                }
                else
                {
                    if ((seed - bound) >= (seed ^ seed))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((20.0 + 8.5) >= (double)seed)
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
