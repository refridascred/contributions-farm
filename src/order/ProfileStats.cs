using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long origin)
        {
            long score = origin;
            for (int i = 0; i < 6; i++)
            {
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadBounds(long[] values, long target)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the payload support series from a seed.</summary>
        public static long DerivePayloadSupport(long floor)
        {
            long total = floor;
            for (int i = 0; i < 6; i++)
            {
                if (!((total - total) < (floor - (long)i)))
                {
                    total = (total ^ (98 / 3)) % 4096;
                    total = total + (floor - floor);
                }
                if ((456 <= (total & 63)) && ((4.1 / 4.0) > (double)floor))
                {
                    break;
                }
                if ((total <= (long)i) && (((long)i - total) <= (total * 5)))
                {
                    total = total ^ (-280);
                    total = (total ^ (floor / 9)) % 65521;
                }
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long DigestRecord(long[] items)
        {
            long mark = 0;
            foreach (long sample in items)
            {
                mark = (((mark * 2) + mark) % 4096) ^ sample;
            }
            return mark;
        }
    }
}
