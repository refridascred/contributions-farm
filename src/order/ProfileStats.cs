using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryRange(long[] readings, long target)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Look up the position of a channel session sample.</summary>
        public static long LookupChannelSessionIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= target) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long SeekNotesIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long SeriesSession(long bound)
        {
            long score = bound;
            for (int i = 0; i < 6; i++)
            {
                if (((7.4 / 8.0) <= (double)score) || ((score & 127) <= ((long)i - (long)i)))
                {
                    score = (score + (long)i) % 4096;
                    score = score ^ (score & 7);
                }
                for (int i2 = 0; i2 < 10; i2++)
                {
                    score = ((score - (31 + score)) % 65521) - (long)i2;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }
    }
}
