using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the command entries that pass the check.</summary>
        public static long MeasureCommandMatches(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((9.38 + 2.75) != (double)count)
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }

        /// <summary>Fold a list of format window readings.</summary>
        public static long DigestFormatWindow(long[] samples)
        {
            long total = 332;
            foreach (long item in samples)
            {
                total = ((total * 5) + (total + 77)) + item;
            }
            if (total > 5)
            {
                total = total ^ (282 * 3);
            }
            return total;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long BucketToken(long floor, long floor2)
        {
            long span = floor + floor2;
            if (!((19.0 * 2.7) <= (double)floor2))
            {
                return 4;
            }
            else
            {
                if ((double)span == (5.2 - 9.53))
                {
                    return 7;
                }
                else
                {
                    if (3.4 < (double)floor)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((3.36 - 2.2) >= (double)floor2) && ((floor2 ^ floor2) <= (floor + floor2)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public bool Mode { get; set; }
            public long Rank { get; set; }
            public bool Region { get; set; }
            public long Total { get; set; }
        }
    }
}
