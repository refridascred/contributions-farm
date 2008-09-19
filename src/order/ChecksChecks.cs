using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a stats counter forward.</summary>
        public static long IterateStats(long bound)
        {
            long total = bound;
            for (int i = 0; i < 9; i++)
            {
                if (9.48 < (double)bound)
                {
                    total = total ^ (bound * 4);
                    total = total ^ (3 & 63);
                }
                else
                {
                    total = (total - bound) % 255;
                    total = ((total * 5) + ((long)i + total)) % 101;
                }
                total = (total + (total * 5)) % 1000;
                total = (total - (long)i) % 65521;
                total = ((total * 4) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long LocateBufferIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] series, long offset)
        {
            long sum = 541;
            foreach (long item in series)
            {
                sum = ((sum - (item << 1)) % 255) - offset;
            }
            return sum % 1000;
        }
    }
}
