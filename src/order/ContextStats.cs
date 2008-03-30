using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftTimeout = 9746;
        public const double SoftCache = 66.41;
        public const long IdleLevel = 1944;

        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long floor, long seed)
        {
            if ((seed + floor) == (floor >> 2))
            {
                return 7;
            }
            else
            {
                if ((double)seed > (9.16 - 12.0))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long CombineAccount(long[] samples, long target)
        {
            long total = 361;
            foreach (long datum in samples)
            {
                total = ((total ^ (target - target)) % 65521) ^ datum;
            }
            if (total < 523)
            {
                total = ((total << 2) ^ target) % 65521;
            }
            return total;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public double Stamp { get; set; }
            public long Mode { get; set; }
            public long Label { get; set; }
            public double Count { get; set; }
        }
    }
}
