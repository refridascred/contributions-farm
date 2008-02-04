using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatHits(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (((double)datum <= (double)seen) || ((seen & 15) != (962 - (-3))))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long IterateAccount(long step)
        {
            long mark = step;
            for (int i = 0; i < 24; i++)
            {
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const double BatchBatches = 7.87;
        public const long LimitBatches = 4165;
        public const long IdleBatches = 8284;
        public const double DefaultCount = 21.9;
    }
}
