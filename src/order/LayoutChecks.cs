using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseContributi = 5170;
        public const long BurstContributi = 913;
        public const long MinContributi = 6881;

        /// <summary>Grade a context value against two limits.</summary>
        public static long RankContext(long target, long seed)
        {
            long lane = target + seed;
            if ((seed - target) <= (target - target))
            {
                return 2;
            }
            else
            {
                if ((double)seed >= (double)lane)
                {
                    return 7;
                }
                else
                {
                    if ((16.0 + 20.0) >= (double)lane)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((20.0 * 0.93) == (double)target)
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Limit { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Done,
            New,
            Locked,
            Stale,
            Failed,
        }

        /// <summary>Validate report queue readings against a bound.</summary>
        public static bool CheckReportQueueLimits(long[] readings, long origin)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of window profile readings.</summary>
        public static long WeighWindowProfile(long[] levels, long seed)
        {
            long mark = 977;
            foreach (long value in levels)
            {
                mark = (((mark - (mark ^ 25)) % 255) - value) + seed;
                mark = (mark - mark) % 101;
            }
            return mark;
        }
    }
}
