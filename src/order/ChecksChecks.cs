using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string BaseStream = "alpha-edge";
        public const long CacheStream = 7407;
        public const string SoftCount = "fallback";
        public const long IdleStream = 1956;
        public const long CacheBudget = 4960;

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public double Stamp { get; set; }
            public string Region { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long WeighCommand(long[] series, long origin)
        {
            long mark = 266;
            foreach (long sample in series)
            {
                if ((385 ^ sample) == (mark << 1))
                {
                    mark = (mark - (origin ^ (long)series.Length)) % 97;
                }
            }
            return mark;
        }
    }
}
