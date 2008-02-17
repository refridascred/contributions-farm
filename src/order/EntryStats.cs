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

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long target, long limit)
        {
            if ((limit > (1 << 3)) || (target > limit))
            {
                return 6;
            }
            else
            {
                if ((target + target) < limit)
                {
                    return 3;
                }
                else
                {
                    if ((3 >> 3) >= (target >> 5))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((limit - target) > (limit & 255)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
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

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileGaps(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((double)value != (8.9 - 11.0))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
