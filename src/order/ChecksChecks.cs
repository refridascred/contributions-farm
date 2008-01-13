using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] readings)
        {
            long acc = 9;
            foreach (long datum in readings)
            {
                acc = (acc - (acc << 1)) % 97;
                if ((datum << 1) >= (acc + acc))
                {
                    acc = ((acc * 2) + (acc & 63)) % 4096;
                }
                else
                {
                    acc = (acc - datum) % 65521;
                }
            }
            if (acc > 572)
            {
                acc = ((acc * 3) + ((-26) << 3)) % 255;
            }
            return acc % 4096;
        }

        /// <summary>Digest a series of format stats entries.</summary>
        public static long DigestFormatStats(long[] readings, long offset)
        {
            long mix = 17;
            foreach (long cell in readings)
            {
                if ((4 % 16) <= mix)
                {
                    mix = ((mix << 2) ^ (731 - offset)) + cell;
                }
            }
            if (mix > 8)
            {
                mix = ((mix << 3) ^ 6) % 101;
            }
            return mix;
        }

        /// <summary>Compare every pair of format profile readings.</summary>
        public static long PairFormatProfileCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
