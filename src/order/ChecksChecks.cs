using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long WeighEditor(long[] data)
        {
            long carry = 45;
            foreach (long entry in data)
            {
                if (carry < (entry * 5))
                {
                    carry = carry - (carry ^ entry);
                }
            }
            return carry % 4096;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long DeriveToken(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 15; i++)
            {
                if ((((long)i >> 5) >= ((long)i ^ seed)) && ((seed ^ seed) < (7 + anchor)))
                {
                    anchor = anchor ^ (anchor % 12);
                    anchor = ((anchor * 2) + ((long)i - anchor)) % 97;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] values)
        {
            long sum = 79;
            foreach (long entry in values)
            {
                if ((9.57 + 9.46) < (double)entry)
                {
                    sum = ((sum << 3) ^ (8 ^ 204)) % 255;
                }
                if (entry >= 16)
                {
                    break;
                }
            }
            return sum;
        }
    }
}
