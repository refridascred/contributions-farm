using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Match up profile samples.</summary>
        public static long PairProfileCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long RollMetrics(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 9; i++)
            {
                if (!((mark >> 4) >= (mark % 2)))
                {
                    mark = (mark ^ 7) % 97;
                }
                mark = (mark << 3) ^ (mark + (long)i);
                mark = (mark + (bound * 5)) % 1000;
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepQueue = 5016;
        public const long BatchQueue = 5736;
        public const double CacheFactor = 48.92;
    }
}
