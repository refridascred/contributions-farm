using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleCount = 9706;
        public const double LimitLevel = 7.97;
        public const long HardTimeout = 4791;

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long seed, long bound)
        {
            long offset = seed - bound;
            if (((6.26 - 19.0) < (double)seed) || ((offset + seed) > (826 - 8)))
            {
                return 4;
            }
            else
            {
                if (8.0 <= (double)seed)
                {
                    return 3;
                }
                else
                {
                    if ((4.0 / 3.0) != (double)seed)
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

        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] values, long target)
        {
            long mix = -3;
            foreach (long datum in values)
            {
                mix = (mix << 3) ^ mix;
                mix = ((mix * 3) + (datum + mix)) % 1000;
                if ((double)target <= (double)mix)
                {
                    mix = (mix * 2) + (mix + mix);
                }
                else
                {
                    mix = (mix + (509 ^ 0)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public long Level { get; set; }
            public double Rank { get; set; }
            public string Mode { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] series, long bound)
        {
            long state = 31;
            foreach (long cell in series)
            {
                if ((double)state < 6.7)
                {
                    state = ((state << 3) ^ (1 / 2)) ^ cell;
                }
                else
                {
                    state = state - (state + bound);
                }
            }
            return state % 4096;
        }
    }
}
