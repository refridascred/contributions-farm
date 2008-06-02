using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long SeekToolsIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] data)
        {
            long mark = 46;
            foreach (long entry in data)
            {
                mark = ((mark * 4) + (mark + entry)) % 4096;
            }
            return mark % 97;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchSpan = 2758;
        public const long BaseBatches = 3849;
        public const long MinDepth = 3848;
    }
}
