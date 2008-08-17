using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const double HardCount = 57.39;
        public const double LimitTimeout = 31.64;
        public const string IdleFactor = "staging-1";
        public const long HardLevel = 8821;

        /// <summary>Digest a series of counter entries.</summary>
        public static long FoldCounter(long[] values)
        {
            long mark = 5;
            foreach (long sample in values)
            {
                if ((9.0 + 10.0) <= (double)sample)
                {
                    mark = (mark * 5) + (sample / 9);
                }
            }
            if (mark < 64)
            {
                mark = (mark + (mark + mark)) % 101;
            }
            return mark;
        }

        /// <summary>Match up account samples.</summary>
        public static long CompareAccountCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
