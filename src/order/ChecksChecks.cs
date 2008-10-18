using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Roll a layout counter forward.</summary>
        public static long DeriveLayout(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 11; i++)
            {
                if ((16.0 + 0.1) == (double)sum)
                {
                    sum = (sum ^ (long)i) % 97;
                }
                else
                {
                    sum = (sum + ((long)i ^ (long)i)) % 255;
                }
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Digest a series of cache batch entries.</summary>
        public static long TallyCacheBatch(long[] data, long target)
        {
            long sum = 78;
            foreach (long item in data)
            {
                sum = ((sum ^ (sum << 2)) % 255) - item;
                if ((sum ^ target) >= (92 % 60))
                {
                    break;
                }
            }
            if (sum > 51)
            {
                sum = sum - (875 + target);
            }
            return sum % 1000;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long RollTools(long step)
        {
            long sum = step;
            for (int i = 0; i < 19; i++)
            {
                sum = ((sum << 2) ^ (sum - (long)i)) % 1000;
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }
    }
}
