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

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long MatchTokenCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
