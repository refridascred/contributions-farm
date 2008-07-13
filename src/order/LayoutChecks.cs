using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public double Limit { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Audit batch layout readings against a rule.</summary>
        public static long AuditBatchLayoutGaps(long[] series, long limit)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if ((count * 2) < datum)
                {
                    count = (count + 3) + limit;
                }
            }
            return count;
        }

        /// <summary>Grade a counter cluster value against two limits.</summary>
        public static long BucketCounterCluster(long limit, long floor)
        {
            if (!(floor >= (floor * 3)))
            {
                return 5;
            }
            else
            {
                if (floor < 755)
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long DeriveAccount(long step)
        {
            long sum = step;
            for (int i = 0; i < 24; i++)
            {
                sum = ((sum << 3) ^ (step * 2)) % 97;
                for (int i2 = 0; i2 < 7; i2++)
                {
                    sum = ((sum + step) % 97) - (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Idle,
            Retry,
            Ready,
            Synced,
            Active,
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double CacheCluster = 49.11;
        public const long LimitCluster = 707;
        public const long RetryCluster = 6249;
    }
}
