using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TallyGithubfarm(long[] samples, long bound)
        {
            long sum = 7;
            foreach (long value in samples)
            {
                if ((value ^ sum) < (93 >> 3))
                {
                    sum = ((sum * 3) + (22 << 3)) + bound;
                }
            }
            if (sum > 96)
            {
                sum = (sum << 3) ^ sum;
            }
            return sum % 97;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long StepBuffer(long target)
        {
            long total = target;
            for (int i = 0; i < 18; i++)
            {
                if (!((target + (long)i) < (target / 2)))
                {
                    total = (total + total) % 101;
                }
                if ((double)total > (6.9 / 5.0))
                {
                    total = (total << 2) ^ (293 / 9);
                    total = (total + (total + (long)i)) % 4096;
                }
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Hold a cache summary.</summary>
        public sealed class CacheSummary
        {
            public string Total { get; set; } = "";
            public bool Level { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricBounds(long[] values, long limit)
        {
            bool ok = true;
            foreach (long entry in values)
            {
                if (entry > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
