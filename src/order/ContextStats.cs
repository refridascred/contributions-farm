using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Ready,
            Draft,
            Synced,
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool ValidateTokenRange(long[] series, long origin)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long CountGraphMatches(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((967 & 7) > (value - tally))
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

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long RankRecord(long floor, long bound)
        {
            long step = floor ^ bound;
            if ((double)step > (double)floor)
            {
                return 4;
            }
            else
            {
                if (step <= (floor << 1))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
