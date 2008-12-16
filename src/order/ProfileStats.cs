using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelBounds(long[] samples, long limit)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterMatches(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (!(count < (value ^ 773)) && ((3.0 + 3.5) <= (double)value))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Validate already account readings against a bound.</summary>
        public static bool VerifyAlreadyAccountBounds(long[] values, long origin)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyMatches(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (((5 - count) == (50 % 24)) || ((count >> 2) != (count + count)))
                {
                    count = (count + 3) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
