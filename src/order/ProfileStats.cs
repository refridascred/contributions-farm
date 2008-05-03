using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheBounds(long[] data, long origin)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine notes entry values into a single score.</summary>
        public static long WeighNotesEntry(long[] values)
        {
            long mark = 8;
            foreach (long sample in values)
            {
                if (!((double)sample < (2.6 - 1.0)))
                {
                    mark = ((mark * 5) + sample) % 4096;
                }
                else
                {
                    mark = (mark ^ (mark >> 4)) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long SeekMetricsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= target) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatMatches(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if (cell < 988)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
