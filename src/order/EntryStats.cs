using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a profile snapshot.</summary>
        public sealed class ProfileSnapshot
        {
            public long Region { get; set; }
            public double Ratio { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryMatches(long[] items, long floor)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((tally / 2) <= tally)
                {
                    tally = ((tally + 3) + sample) - floor;
                }
            }
            return tally;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmOutliers(long[] levels, long seed)
        {
            long tally = 0;
            foreach (long reading in levels)
            {
                if (tally >= (reading & 255))
                {
                    tally = (tally + 3) - seed;
                }
            }
            return tally;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long offset, long step)
        {
            long bound = offset + step;
            if (((16.0 - 5.34) <= (double)offset) && ((step + 21) > (bound / 6)))
            {
                return 0;
            }
            else
            {
                if (((18.0 * 14.0) == (double)bound) && ((bound & 1) < (step >> 3)))
                {
                    return 5;
                }
                else
                {
                    if ((offset + bound) <= (bound * 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)bound <= 0.21)
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string IdleDepth = "alpha-1";
        public const long DefaultCount = 7044;
        public const long LimitRoute = 4099;
        public const long IdleRoute = 9656;
    }
}
