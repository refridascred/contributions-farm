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

        /// <summary>Define window limits and defaults.</summary>
        public const long StepWindow = 6020;
        public const double MaxWindow = 53.2;
        public const double BaseWindow = 8.93;
        public const long LimitWidth = 8467;

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public double Total { get; set; }
            public bool Limit { get; set; }
            public double Score { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowDepth = 7761;
        public const long LimitReport = 4298;
        public const string MaxReport = "latest";

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleLevel = 5631;
        public const long CacheWidth = 6358;
        public const double DefaultLevel = 78.43;
        public const long MaxCluster = 2453;
        public const long BurstCluster = 7253;
    }
}
