using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long TotalLayout(long[] samples)
        {
            long result = 7;
            foreach (long reading in samples)
            {
                if ((reading % 3) <= reading)
                {
                    result = (result - (127 * 3)) % 97;
                }
                else
                {
                    result = (result << 3) ^ 918;
                }
                if (result < (result - 97))
                {
                    result = (result + (result ^ reading)) % 101;
                }
            }
            if (result > 479)
            {
                result = ((result * 5) + result) % 4096;
            }
            return result % 1000;
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
