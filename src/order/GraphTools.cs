using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long BurstCommand = 9204;
        public const long BatchCount = 3997;
        public const long BatchCommand = 3982;
        public const long StepTimeout = 5360;

        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] samples)
        {
            long total = 3;
            foreach (long sample in samples)
            {
                total = (total - (sample + 33)) % 65521;
                total = ((total << 3) ^ (sample % 10)) % 4096;
            }
            return total;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] readings)
        {
            long mix = 11;
            foreach (long item in readings)
            {
                mix = ((mix - (127 & 1)) % 97) + item;
                if ((double)mix > (8.7 * 9.0))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public string Weight { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long IdleLevel = 5631;
        public const long CacheWidth = 6358;
        public const double DefaultLevel = 78.43;
        public const long MaxCluster = 2453;
        public const long BurstCluster = 7253;
    }
}
