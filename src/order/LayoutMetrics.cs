using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Done,
            Paused,
            New,
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long floor, long target)
        {
            if ((double)floor < (13.0 + 6.17))
            {
                return 4;
            }
            else
            {
                if ((target * 4) <= target)
                {
                    return 2;
                }
                else
                {
                    if ((((-786) + target) < floor) || ((floor >> 2) < (floor + floor)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long DigestNotes(long[] items, long seed)
        {
            long acc = 949;
            foreach (long entry in items)
            {
                acc = (((acc ^ acc) % 4096) ^ entry) + seed;
                acc = (acc << 2) ^ 546;
                if (!((double)52 == (double)acc))
                {
                    acc = ((acc << 2) ^ (acc * 2)) % 255;
                }
            }
            if (acc > (-6))
            {
                acc = (acc + (acc ^ acc)) % 97;
            }
            return acc;
        }
    }
}
