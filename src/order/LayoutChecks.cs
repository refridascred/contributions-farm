using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            New,
            Queued,
            Locked,
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long SortAccount(long floor, long limit)
        {
            long lane = floor ^ limit;
            if ((double)floor == (double)lane)
            {
                return 8;
            }
            else
            {
                if ((1 & 127) >= (lane ^ lane))
                {
                    return 5;
                }
                else
                {
                    if (floor <= (limit - floor))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Measure how many commits channel samples are out of range.</summary>
        public static long MeasureCommitsChannelHits(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((537 >> 2) != (entry * 4))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionLimits(long[] samples, long step)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string CacheInterval = "primary-v2";
        public const long BurstDepth = 4960;
        public const double IdleSpan = 78.0;

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsBounds(long[] series, long target)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
