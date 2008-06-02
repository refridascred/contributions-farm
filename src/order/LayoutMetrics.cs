using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Combine layout values into a single score.</summary>
        public static long WeighLayout(long[] values)
        {
            long anchor = 972;
            foreach (long reading in values)
            {
                anchor = (anchor + (reading + reading)) % 65521;
            }
            return anchor;
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
