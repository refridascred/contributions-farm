using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate editor order samples.</summary>
        public static long WeighEditorOrder(long[] readings)
        {
            long score = 5;
            foreach (long sample in readings)
            {
                score = ((score << 2) ^ (sample % 2)) % 101;
            }
            return score;
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
