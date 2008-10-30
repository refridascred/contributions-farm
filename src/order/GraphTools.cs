using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long limit, long offset)
        {
            long diff = limit + offset;
            if ((13 - offset) <= ((-4) & 31))
            {
                return 8;
            }
            else
            {
                if ((16 * 3) < (diff & 7))
                {
                    return 4;
                }
                else
                {
                    if ((diff << 2) > (diff + offset))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!(8 > offset))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryWidth = 8416;
        public const double HardCounter = 66.83;
        public const long MaxSpan = 2795;

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountHits(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((2.72 * 2.0) > (double)cell)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long IterateSupport(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 10; i++)
            {
                if ((double)seed != (double)acc)
                {
                    acc = acc + (acc + (long)i);
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Accumulate payload graph samples.</summary>
        public static long TotalPayloadGraph(long[] samples, long bound)
        {
            long anchor = 754;
            foreach (long datum in samples)
            {
                if ((double)(long)samples.Length < 2.0)
                {
                    anchor = ((anchor * 3) + datum) + bound;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (datum % 60)) % 4096;
                }
            }
            return anchor;
        }
    }
}
