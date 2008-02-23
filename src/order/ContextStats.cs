using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Compare every pair of stream readings.</summary>
        public static long OverlapStreamCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double MinFactor = 44.14;
        public const string HardEditor = "legacy";
        public const double MinEditor = 6.87;

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public long Score { get; set; }
            public double Stamp { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] values)
        {
            long mark = 46;
            foreach (long cell in values)
            {
                mark = (mark - mark) % 4096;
                mark = (mark * 2) + (cell + mark);
                if ((double)cell > 0.6)
                {
                    mark = ((mark << 2) ^ (mark + mark)) % 255;
                }
            }
            if (mark > 654)
            {
                mark = (mark << 3) ^ (mark + mark);
            }
            return mark;
        }
    }
}
