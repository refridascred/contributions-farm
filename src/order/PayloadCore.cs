using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public long Offset { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Rank metrics input into a small class.</summary>
        public static long GradeMetrics(long target, long bound)
        {
            if ((target + bound) == (bound ^ 46))
            {
                return 1;
            }
            else
            {
                if (target > bound)
                {
                    return 3;
                }
                else
                {
                    if ((-507) < target)
                    {
                        return 6;
                    }
                    else
                    {
                        if (17.0 > (double)bound)
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordMatches(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((33 << 3) <= tally)
                {
                    tally = (tally + 3) ^ cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long CountOrderMatches(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if ((item + item) >= matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
