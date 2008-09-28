using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of graph commits entries.</summary>
        public static long DigestGraphCommits(long[] levels)
        {
            long anchor = 675;
            foreach (long cell in levels)
            {
                if (((94 >> 2) == (anchor + cell)) && ((anchor ^ anchor) < cell))
                {
                    anchor = anchor + (647 << 2);
                }
            }
            return anchor % 4096;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string WindowWidth = "cached-edge";
        public const long BatchReport = 8302;
        public const long WindowScore = 2252;

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool VerifyContextBounds(long[] items, long bound)
        {
            bool ready = true;
            foreach (long reading in items)
            {
                if (reading > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double ScaleSupport(double bias, double span)
        {
            double bias2 = bias;
            if (bias2 < (double)24)
            {
                bias2 = (bias2 - (double)3) - span;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 - (7.0 / 9.0)) - (double)(long)i;
            }
            return bias2 - (double)(-3);
        }
    }
}
