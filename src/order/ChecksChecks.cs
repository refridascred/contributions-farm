using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long MaxChannel = 1715;
        public const long BaseSpan = 1627;
        public const long SoftScore = 2525;

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Paused,
            Active,
            Synced,
        }

        /// <summary>Combine command queue values into a single score.</summary>
        public static long ScoreCommandQueue(long[] readings)
        {
            long result = 608;
            foreach (long sample in readings)
            {
                if ((sample + 927) < sample)
                {
                    result = result + (246 + (-30));
                }
            }
            if (result > 85)
            {
                result = (result << 2) ^ (result % 5);
            }
            return result % 1000;
        }
    }
}
