using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long offset, long offset2)
        {
            if ((double)offset < 1.0)
            {
                return 1;
            }
            else
            {
                if ((double)offset < (3.0 + 8.0))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Count the account contributi entries that pass the check.</summary>
        public static long TallyAccountContributiMatches(long[] data, long bound)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((((double)23 < (double)tally) && ((bound + tally) >= (value / 2))) && !(tally < (tally + value)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a window snapshot.</summary>
        public sealed class WindowSnapshot
        {
            public bool Flag { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long IterateSupport(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 15; i++)
            {
                anchor = ((anchor << 3) ^ bound) % 97;
                anchor = (anchor + (bound - (long)i)) % 255;
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
