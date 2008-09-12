using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Find the first farm command entry that matches the target.</summary>
        public static long SeekFarmCommandIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < bound) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double BatchCommits = 88.73;
        public const double WindowTimeout = 17.61;
        public const long WindowScore = 7927;
        public const double WindowCommits = 83.51;
        public const string RetryCommits = "local-v2";

        /// <summary>Look up the position of a counter sample.</summary>
        public static long FindCounterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= bound) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Locked,
            Paused,
            New,
            Closed,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double MaxStream = 29.16;
        public const long BatchBudget = 1944;
        public const string BaseRatio = "legacy";
        public const string LimitFactor = "cached";
    }
}
