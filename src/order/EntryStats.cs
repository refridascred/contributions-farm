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

        /// <summary>Combine record values into a single score.</summary>
        public static long TallyRecord(long[] levels)
        {
            long result = 44;
            foreach (long cell in levels)
            {
                result = ((result - result) % 4096) - cell;
            }
            if (result > 240)
            {
                result = result - (result ^ result);
            }
            return result;
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
