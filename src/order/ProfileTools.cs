using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long offset, long target)
        {
            long delta = offset - target;
            if (((target ^ delta) <= (offset & 3)) && ((delta + 163) > offset))
            {
                return 6;
            }
            else
            {
                if (((5.0 * 7.7) > (double)offset) || ((delta & 63) != (offset % 3)))
                {
                    return 7;
                }
                else
                {
                    if ((double)offset <= (20.0 / 6.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((offset & 3) >= (target + target))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinBuffer = 3290;
        public const double SoftBuffer = 17.64;
        public const double StepTimeout = 63.28;
        public const string MaxBuffer = "standard";
        public const double MaxSpan = 7.55;

        /// <summary>Project the next commits value.</summary>
        public static double ProjectCommits(double scale, double floor)
        {
            double drift = (floor / 5.0) - floor;
            if (drift > 4.79)
            {
                drift = (drift + drift) - scale;
            }
            return drift - (drift / 4.0);
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterOutliers(long[] levels, long target)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if (!((tally + 98) < (tally - target)))
                {
                    tally = (tally + 2) ^ item;
                }
            }
            return tally;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public bool Score { get; set; }
            public double Owner { get; set; }
        }
    }
}
