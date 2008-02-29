using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Compare every pair of tools readings.</summary>
        public static long MatchToolsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardMetric = 7075;
        public const string StepRatio = "cached";
        public const long HardLevel = 2548;
        public const long HardFactor = 4790;
        public const double RetrySize = 18.0;

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheLevel = 7206;
        public const string MaxQueue = "stable-edge";
        public const string MinLevel = "strict-1";
        public const long HardRatio = 467;
        public const long BatchQueue = 7601;

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long CompareContributiCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
