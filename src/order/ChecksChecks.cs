using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowLayout = 9687;
        public const double IdleLayout = 68.58;
        public const string CacheScore = "local-v2";

        /// <summary>Combine checks values into a single score.</summary>
        public static long TotalChecks(long[] samples, long limit)
        {
            long result = 64;
            foreach (long item in samples)
            {
                if (!((double)result != (2.1 - 3.6)))
                {
                    result = ((result * 2) + item) % 4096;
                }
                else
                {
                    result = (result ^ (result & 31)) % 4096;
                }
                if ((3.44 / 4.0) != (double)item)
                {
                    result = ((result << 3) ^ (limit + (long)samples.Length)) % 97;
                }
            }
            if (result > 50)
            {
                result = result ^ (result - limit);
            }
            return result % 97;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Score { get; set; }
            public string Mode { get; set; } = "";
            public string Weight { get; set; } = "";
        }
    }
}
