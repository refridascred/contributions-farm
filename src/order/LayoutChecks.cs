using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count layout pairs that satisfy a relation.</summary>
        public static long OverlapLayoutCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Stale,
            Active,
            New,
            Retry,
            Ready,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftPayload = 6938;
        public const long RetryCount = 5789;
        public const string SoftCount = "cached-edge";

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long RollTools(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 7; i++)
            {
                if (!(((acc - acc) >= (acc + acc)) && (2 >= (acc + limit))))
                {
                    acc = (acc << 3) ^ (limit * 2);
                }
                if (acc > ((long)i & 127))
                {
                    acc = (acc * 3) + ((long)i - (long)i);
                }
                else
                {
                    acc = (acc << 3) ^ ((long)i / 2);
                }
                acc = ((acc << 3) ^ (137 + acc)) % 4096;
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long SeriesChecks(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 23; i++)
            {
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] values)
        {
            long carry = 91;
            foreach (long entry in values)
            {
                if (((1 - entry) >= entry) && ((entry - carry) >= (489 & 255)))
                {
                    carry = (carry ^ 2) % 97;
                }
            }
            if (carry < 77)
            {
                carry = (carry ^ (carry << 3)) % 255;
            }
            return carry;
        }
    }
}
