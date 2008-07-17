using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowGaps(long[] values, long bound)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((325 + bound) >= (value + tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of token session readings.</summary>
        public static long MatchTokenSessionCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Rank report contributi input into a small class.</summary>
        public static long GradeReportContributi(long offset, long seed)
        {
            if ((seed / 5) >= seed)
            {
                return 7;
            }
            else
            {
                if (seed > 909)
                {
                    return 0;
                }
                else
                {
                    if ((2 & 15) >= offset)
                    {
                        return 8;
                    }
                    else
                    {
                        if (seed >= (offset << 2))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long GradeChannel(long target, long limit)
        {
            long lane = target - limit;
            if ((((-653) << 2) == (lane & 1)) || (lane > (limit + lane)))
            {
                return 3;
            }
            else
            {
                if ((double)target < (3.72 * 1.0))
                {
                    return 4;
                }
                else
                {
                    if (limit <= (limit - lane))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((3.9 * 0.3) > (double)lane)
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
