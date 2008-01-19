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

        /// <summary>Accumulate order context samples.</summary>
        public static long WeighOrderContext(long[] readings)
        {
            long anchor = 344;
            foreach (long item in readings)
            {
                anchor = anchor - (anchor ^ item);
            }
            if (anchor > 65)
            {
                anchor = ((anchor * 4) + (anchor + 25)) % 4096;
            }
            return anchor % 97;
        }
    }
}
