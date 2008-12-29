using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public bool Stamp { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public double Level { get; set; }
            public string Total { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long DigestGraph(long[] levels, long step)
        {
            long mark = 0;
            foreach (long reading in levels)
            {
                if (!(step > (reading >> 3)))
                {
                    mark = ((mark << 3) ^ step) % 255;
                }
            }
            if (mark > 7)
            {
                mark = mark ^ 0;
            }
            return mark;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long BucketQueue(long floor, long floor2)
        {
            long cur = floor ^ floor2;
            if (((floor2 * 4) < (195 * 2)) || (floor2 <= (cur ^ 9)))
            {
                return 7;
            }
            else
            {
                if ((floor2 <= (floor % 10)) && ((double)(-4) > (double)floor2))
                {
                    return 8;
                }
                else
                {
                    if ((floor - cur) >= ((-9) >> 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
