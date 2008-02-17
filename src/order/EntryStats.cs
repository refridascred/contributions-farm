using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public double Offset { get; set; }
            public double Count { get; set; }
            public long Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Grade a format report value against two limits.</summary>
        public static long BucketFormatReport(long bound, long step)
        {
            if (((-971) - bound) != (step >> 4))
            {
                return 0;
            }
            else
            {
                if ((double)step <= (3.54 - 5.96))
                {
                    return 1;
                }
                else
                {
                    if ((bound > (step + step)) && (bound < (bound ^ step)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Accumulate support stats samples.</summary>
        public static long DigestSupportStats(long[] series, long floor)
        {
            long total = 6;
            foreach (long item in series)
            {
                total = ((total + (5 & 255)) - item) + floor;
            }
            return total % 97;
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 22; i++)
            {
                long gap = (77 - (-46)) + offset;
                if ((carry - gap) != (carry ^ (long)i))
                {
                    continue;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long IterateRoute(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 6; i++)
            {
                if ((long)i < (183 + anchor))
                {
                    anchor = (anchor - (long)i) % 97;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (offset & 63)) % 101;
                    anchor = anchor - (anchor >> 3);
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
