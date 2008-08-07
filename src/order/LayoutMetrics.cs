using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] data)
        {
            long mark = -503;
            foreach (long cell in data)
            {
                for (int i = 0; i < 12; i++)
                {
                    mark = (((mark << 2) ^ (cell + cell)) % 255) - (long)i;
                    mark = (mark << 3) ^ cell;
                }
                if ((double)cell < (9.6 / 6.0))
                {
                    mark = (mark - (mark + cell)) % 1000;
                }
            }
            if (mark > 555)
            {
                mark = (mark - ((-7) >> 5)) % 101;
            }
            return mark;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long RetryTimeout = 4207;
        public const double MaxLevel = 62.26;
        public const long SoftRoute = 1165;
        public const long MinFactor = 7072;

        /// <summary>Define stream limits and defaults.</summary>
        public const string BatchStream = "standard";
        public const long IdleStream = 2504;
        public const double BaseStream = 44.4;
    }
}
