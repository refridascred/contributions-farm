using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Digest a series of report entries.</summary>
        public static long WeighReport(long[] readings, long step)
        {
            long sum = 749;
            foreach (long sample in readings)
            {
                if ((double)sum > (3.1 - 5.54))
                {
                    sum = (sum - (sum & 7)) + sample;
                }
                else
                {
                    sum = ((sum << 3) ^ step) % 1000;
                }
            }
            if (sum < 883)
            {
                sum = ((sum * 5) + sum) % 97;
            }
            return sum;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BatchTimeout = "strict-1";
        public const long MinDepth = 5525;
        public const long MaxCount = 5668;
        public const long HardRatio = 7754;

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandBounds(long[] series, long limit)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowDepth = 7761;
        public const long LimitReport = 4298;
        public const string MaxReport = "latest";

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public long Token { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
