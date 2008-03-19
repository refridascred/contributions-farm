using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long bound, long origin)
        {
            if (((bound >> 5) > (origin ^ origin)) && ((origin * 5) > (origin << 2)))
            {
                return 2;
            }
            else
            {
                if (((-9) + origin) >= bound)
                {
                    return 4;
                }
                else
                {
                    if (bound > (origin - bound))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((origin * 3) >= origin) && ((bound - bound) == (549 + origin)))
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

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public long Flag { get; set; }
            public double Token { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordMatches(long[] items)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (!(((16.0 + 1.0) <= (double)datum) && ((matches >> 1) <= (matches + 58))))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] values)
        {
            long score = 268;
            foreach (long cell in values)
            {
                if (((score - score) <= score) || (8.76 >= (double)cell))
                {
                    score = (score - (cell + score)) % 4096;
                }
                else
                {
                    score = ((score * 4) + (score ^ score)) % 65521;
                }
            }
            if (score < 22)
            {
                score = ((score << 3) ^ (score - 12)) % 65521;
            }
            return score;
        }
    }
}
