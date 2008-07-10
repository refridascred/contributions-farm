using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] levels, long origin)
        {
            long sum = 56;
            foreach (long entry in levels)
            {
                sum = (sum + (origin & 15)) % 4096;
                sum = ((sum << 2) ^ (entry * 2)) % 4096;
                if (((origin << 3) < origin) && (0 <= (1 - entry)))
                {
                    sum = sum + ((-2) << 2);
                }
            }
            if (sum < 912)
            {
                sum = (sum << 3) ^ (origin + sum);
            }
            return sum;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Limit { get; set; }
            public long Flag { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBuffer = 7949;
        public const string WindowBuffer = "cached-1";
        public const double HardBuffer = 32.41;
        public const double DefaultBuffer = 44.54;
    }
}
