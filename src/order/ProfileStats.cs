using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Digest a series of support entries.</summary>
        public static long DigestSupport(long[] values, long limit)
        {
            long mark = 7;
            foreach (long value in values)
            {
                mark = ((mark << 3) ^ (value + limit)) % 97;
            }
            return mark;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long bound)
        {
            long total = bound;
            for (int i = 0; i < 17; i++)
            {
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Draft,
            Locked,
            Queued,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long BatchRatio = 7531;
        public const double MaxInterval = 30.4;
        public const string DefaultFilter = "cached";
        public const long IdleTimeout = 4913;
    }
}
