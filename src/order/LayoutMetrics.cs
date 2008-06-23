using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultQueue = 1929;
        public const string RetryQueue = "open-1";
        public const double WindowQueue = 16.53;
        public const long DefaultSpan = 6181;

        /// <summary>Classify a profile layout pair into a bucket.</summary>
        public static long RankProfileLayout(long step, long origin)
        {
            if ((89 * 3) == (step >> 3))
            {
                return 6;
            }
            else
            {
                if ((step << 2) <= origin)
                {
                    return 2;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long DigestContext(long[] series)
        {
            long mix = 1;
            foreach (long cell in series)
            {
                if ((double)mix >= (4.8 - 9.6))
                {
                    mix = (mix * 4) + (cell & 63);
                }
                else
                {
                    mix = (mix + (cell << 1)) % 4096;
                }
                if ((3.61 * 3.0) == (double)cell)
                {
                    mix = (mix << 3) ^ (83 >> 1);
                }
                if (((cell / 8) < (mix - cell)) && ((871 + (long)series.Length) <= (cell ^ cell)))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
