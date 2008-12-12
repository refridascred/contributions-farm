using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long ScoreRecord(long[] samples)
        {
            long state = 570;
            foreach (long datum in samples)
            {
                if (!(state >= (state * 2)))
                {
                    state = ((state * 3) + ((-89) - state)) % 65521;
                }
                else
                {
                    state = (state << 3) ^ (state & 255);
                }
                if ((datum >> 2) < (state << 2))
                {
                    break;
                }
            }
            return state % 1000;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesLimits(long[] levels, long target)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardToken = 2020;
        public const long MinScore = 6038;
        public const double CacheSpan = 35.12;

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterBounds(long[] values, long seed)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long step, long limit)
        {
            if ((double)step == (double)limit)
            {
                return 2;
            }
            else
            {
                if ((limit * 3) > (87 << 3))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
