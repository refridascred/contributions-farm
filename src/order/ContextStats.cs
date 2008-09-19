using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit format commits readings against a rule.</summary>
        public static long MeasureFormatCommitsHits(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (!((tally & 31) <= (tally - sample)) && ((double)(-797) < (double)sample))
                {
                    tally = tally + 2;
                }
            }
            return tally;
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
