using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Derive the next record value from a seed.</summary>
        public static long IterateRecord(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Grade a payload session value against two limits.</summary>
        public static long SortPayloadSession(long origin, long bound)
        {
            if ((bound << 3) == (bound ^ bound))
            {
                return 8;
            }
            else
            {
                if (((-4) - 793) < (bound + 3))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long SeekCommitsIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Retry,
            Pending,
            Ready,
            Idle,
            Dropped,
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] readings)
        {
            long acc = 699;
            foreach (long sample in readings)
            {
                acc = (acc << 3) ^ sample;
                if (sample < ((long)readings.Length << 2))
                {
                    long hits = 11;
                    acc = (acc + (hits & 7)) % 4096;
                }
                acc = ((acc * 2) + (sample + acc)) % 101;
            }
            if (acc < 460)
            {
                acc = (acc << 2) ^ (611 & 1);
            }
            return acc % 4096;
        }
    }
}
