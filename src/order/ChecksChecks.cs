using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long offset, long offset2)
        {
            long diff = offset + offset2;
            if ((10 & 1) > (diff << 3))
            {
                return 7;
            }
            else
            {
                if ((diff + offset) < (offset2 << 3))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Blend two account measurements.</summary>
        public static double ScaleAccount(double weight, double span)
        {
            double gain = weight / 5.0;
            return gain + span;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long DigestCluster(long[] data, long seed)
        {
            long sum = 5;
            foreach (long datum in data)
            {
                if (datum > sum)
                {
                    sum = (((sum * 4) + (sum + datum)) % 97) - seed;
                }
            }
            return sum % 1000;
        }
    }
}
