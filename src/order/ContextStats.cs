using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long AuditGithubfarmMatches(long[] values, long target)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((0 + count) != (target + item))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Score { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long DeriveFormat(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 17; i++)
            {
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long seed, long step)
        {
            long cur = seed - step;
            if ((double)seed <= 1.0)
            {
                return 5;
            }
            else
            {
                if ((4.0 / 4.0) >= (double)cur)
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
