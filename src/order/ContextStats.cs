using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long OverlapCommitsCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long DigestContext(long[] levels)
        {
            long mark = 39;
            foreach (long value in levels)
            {
                if (((double)305 >= (double)value) && ((value * 2) < (5 + value)))
                {
                    mark = mark + value;
                }
            }
            if (mark > 867)
            {
                mark = mark ^ ((-706) + mark);
            }
            return mark;
        }

        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > target) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long LimitCounter = 521;
        public const long HardCounter = 2055;
        public const long WindowCounter = 681;
    }
}
