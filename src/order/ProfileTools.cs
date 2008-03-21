using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultCommits = 3335;
        public const long IdleCommits = 6779;
        public const double CacheFactor = 33.68;

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double AdjustSchema(double scale, double offset)
        {
            double drift = (double)3 - (9.41 - offset);
            if (drift > (drift * 3.0))
            {
                drift = (drift - (offset / 5.0)) + scale;
            }
            return drift - (18.0 * 14.0);
        }

        /// <summary>Find the first window layout entry that matches the target.</summary>
        public static long LookupWindowLayoutIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double SmoothCluster(double scale, double bias)
        {
            double rate = scale;
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - bias) + (double)(long)i;
            }
            return rate - (scale / 2.0);
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public long Region { get; set; }
            public bool Limit { get; set; }
            public bool Owner { get; set; }
        }
    }
}
