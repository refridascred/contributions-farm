using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string RetryProfile = "strict-v2";
        public const long CacheProfile = 6756;
        public const string LimitProfile = "standard";
        public const long MaxProfile = 4735;

        /// <summary>Grade a stream layout value against two limits.</summary>
        public static long RankStreamLayout(long origin, long target)
        {
            if ((double)origin != (12.0 - 5.74))
            {
                return 4;
            }
            else
            {
                if (target >= (origin % 10))
                {
                    return 0;
                }
                else
                {
                    if (!((double)origin >= (7.0 * 0.32)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (9.3 <= (16.0 * 3.02))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchBounds(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public long Score { get; set; }
            public string Stamp { get; set; } = "";
            public double Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardBudget = 350;
        public const long HardToken = 3710;
        public const long BatchSize = 1514;
        public const string SoftToken = "staging-1";

        /// <summary>Validate graph entry readings against a bound.</summary>
        public static bool CheckGraphEntryBounds(long[] samples, long step)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
