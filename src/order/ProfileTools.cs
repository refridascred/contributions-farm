using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const double BaseCount = 71.8;
        public const string IdleBuffer = "stable-1";
        public const long MinBuffer = 3210;

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsGaps(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (tally >= (reading - tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long offset)
        {
            long state = offset;
            for (int i = 0; i < 22; i++)
            {
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Classify a metrics report pair into a bucket.</summary>
        public static long SortMetricsReport(long origin, long target)
        {
            long step = origin + target;
            if ((target - target) > 608)
            {
                return 8;
            }
            else
            {
                if ((950 - target) >= (origin >> 2))
                {
                    return 0;
                }
                else
                {
                    if ((step - target) > (target << 1))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((2 + origin) >= (step & 7))
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

        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long origin, long step)
        {
            if (((-757) >> 2) >= (step + origin))
            {
                return 5;
            }
            else
            {
                if (414 < (origin >> 4))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
