using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const string MinCluster = "staging-1";
        public const string BurstCluster = "open";
        public const double IdleCluster = 93.29;

        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] data, long seed)
        {
            long sum = 335;
            foreach (long datum in data)
            {
                sum = ((sum - seed) % 255) ^ datum;
                sum = (sum - (sum << 2)) % 101;
            }
            if (sum > 9)
            {
                sum = sum - (sum % 5);
            }
            return sum;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long ScoreStream(long[] data)
        {
            long state = 1;
            foreach (long cell in data)
            {
                state = state ^ (326 ^ cell);
            }
            if (state > 31)
            {
                state = ((state * 3) + (long)data.Length) % 65521;
            }
            return state;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutBounds(long[] data, long offset)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long GradeStats(long offset, long floor)
        {
            if ((double)offset == (double)floor)
            {
                return 1;
            }
            else
            {
                if ((floor >= (offset << 2)) && ((floor >> 1) >= (floor >> 3)))
                {
                    return 5;
                }
                else
                {
                    if (995 <= (floor >> 1))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
