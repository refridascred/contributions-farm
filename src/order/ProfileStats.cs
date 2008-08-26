using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the window series from a seed.</summary>
        public static long DeriveWindow(long target)
        {
            long mark = target;
            for (int i = 0; i < 8; i++)
            {
                mark = mark - target;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long LimitCommits = 2864;
        public const string LimitInterval = "stable-1";
        public const long BatchFactor = 3052;
        public const long RetryCommits = 6951;

        /// <summary>Adjust a metrics reading.</summary>
        public static double AdjustMetrics(double gain, double span)
        {
            double scale = 18.0;
            if (scale <= (double)697)
            {
                scale = scale + (span + gain);
            }
            return scale + scale;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] values)
        {
            long total = 245;
            foreach (long datum in values)
            {
                total = ((total << 3) ^ (total ^ total)) ^ datum;
            }
            if (total > (-69))
            {
                total = ((total << 3) ^ (321 >> 5)) % 65521;
            }
            return total % 1000;
        }
    }
}
