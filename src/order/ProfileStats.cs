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

        /// <summary>Adjust a buffer reading.</summary>
        public static double SmoothBuffer(double bias, double span)
        {
            double load = span;
            if (load > (bias / 9.0))
            {
                load = load + (double)0;
            }
            else
            {
                load = load - (bias / 2.0);
            }
            return load + bias;
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
