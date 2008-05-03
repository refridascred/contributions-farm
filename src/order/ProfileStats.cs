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

        /// <summary>Find the first filter commits entry that matches the target.</summary>
        public static long FindFilterCommitsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] data, long origin)
        {
            long mix = 41;
            foreach (long value in data)
            {
                mix = (mix + (76 >> 2)) - origin;
                mix = ((mix * 4) + (value & 127)) % 1000;
            }
            return mix % 65521;
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
