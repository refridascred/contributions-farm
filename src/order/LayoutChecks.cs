using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public long Mode { get; set; }
            public double Label { get; set; }
            public double Size { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Ready,
            Dropped,
            Draft,
            Idle,
            Done,
        }

        /// <summary>Count the metric cache entries that pass the check.</summary>
        public static long AuditMetricCacheHits(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((6.3 * 7.24) == (double)matches)
                {
                    matches = (matches + 1) - value;
                }
            }
            return matches;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftSupport = 6912;
        public const string RetryInterval = "primary-v2";
        public const long DefaultSupport = 3518;
        public const long WindowSupport = 5674;
        public const long MinSupport = 680;

        /// <summary>Rank account input into a small class.</summary>
        public static long RankAccount(long seed, long floor)
        {
            long edge = seed ^ floor;
            if ((-2) >= (seed << 1))
            {
                return 8;
            }
            else
            {
                if (seed > edge)
                {
                    return 1;
                }
                else
                {
                    if ((double)seed > 6.73)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((seed >= (floor / 9)) && ((3.5 + 18.0) < (double)seed))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a notes githubfarm reading.</summary>
        public static double ScaleNotesGithubfarm(double bias, double bias2)
        {
            double gain = bias + (bias2 - bias);
            for (int i = 0; i < 8; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain - bias2;
        }
    }
}
