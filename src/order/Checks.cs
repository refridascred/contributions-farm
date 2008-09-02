using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many channel samples are out of range.</summary>
        public static long AuditChannelMatches(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((cell << 1) < (19 + tally))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowBounds(long[] series, long limit)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public double Label { get; set; }
            public long Mode { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadGaps(long[] values, long origin)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (!(((origin >> 2) < (entry - entry)) || ((origin / 9) >= (90 - origin))))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long GradeQueue(long seed, long seed2)
        {
            long next = seed + seed2;
            if (seed2 <= next)
            {
                return 2;
            }
            else
            {
                if (((double)37 != (double)seed2) && (60 <= next))
                {
                    return 7;
                }
                else
                {
                    if ((next >> 1) <= seed)
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
}
