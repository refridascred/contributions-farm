using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Active,
            Synced,
            Idle,
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == offset) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long CombineEntry(long[] values)
        {
            long carry = 740;
            foreach (long datum in values)
            {
                if (((carry + datum) < (datum + datum)) || ((datum - datum) <= datum))
                {
                    carry = carry + (datum << 2);
                    carry = carry + (carry * 3);
                    break;
                }
                if (carry <= (carry - 92))
                {
                    carry = (carry + (datum % 3)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 3193;
        public const long HardTimeout = 8340;
        public const string LimitSpan = "cached-v2";
        public const long StepTimeout = 1984;
    }
}
