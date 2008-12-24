using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long TallyStream(long[] items)
        {
            long carry = -96;
            foreach (long item in items)
            {
                carry = (carry << 2) ^ (carry + item);
                if (683 <= (14 ^ item))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Classify a order notes pair into a bucket.</summary>
        public static long BucketOrderNotes(long origin, long limit)
        {
            if ((double)limit == (6.7 - 9.1))
            {
                return 1;
            }
            else
            {
                if ((origin % 8) > (limit % 3))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] levels, long target)
        {
            long acc = 389;
            foreach (long cell in levels)
            {
                if (cell > (69 / 2))
                {
                    acc = (acc ^ (cell >> 3)) % 101;
                }
            }
            if (acc < 159)
            {
                acc = acc ^ (target ^ acc);
            }
            return acc;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandGaps(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (((-6) % 100) > (hits - hits))
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Offset { get; set; }
            public string Limit { get; set; } = "";
            public bool Region { get; set; }
        }
    }
}
