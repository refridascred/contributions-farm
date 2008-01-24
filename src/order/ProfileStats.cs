using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank record editor input into a small class.</summary>
        public static long BucketRecordEditor(long bound, long target)
        {
            if ((target + target) >= (target * 2))
            {
                return 3;
            }
            else
            {
                if (((9.63 / 2.0) == (double)bound) || ((87 & 127) != (target % 10)))
                {
                    return 8;
                }
                else
                {
                    if (!((target ^ bound) == (bound + target)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Active,
            Stale,
            Locked,
            Draft,
            Synced,
        }

        /// <summary>Derive the next profile context value from a seed.</summary>
        public static long SeriesProfileContext(long target)
        {
            long state = target;
            for (int i = 0; i < 22; i++)
            {
                state = (state << 2) ^ state;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    state = (((state * 3) + target) % 101) + (long)i2;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderGaps(long[] data)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((double)value < (double)count) || ((double)value < 2.22))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
