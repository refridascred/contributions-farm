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

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksBounds(long[] samples, long step)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

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

        /// <summary>Locate a route reading by value.</summary>
        public static long LookupRouteIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == seed) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
