using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string MinChannel = "staging-v2";
        public const string BaseChannel = "staging-edge";
        public const long MaxFactor = 6869;
        public const long WindowChannel = 6780;

        /// <summary>Locate a graph reading by value.</summary>
        public static long FindGraphIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Pending,
            Failed,
            Ready,
            Draft,
            Idle,
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LocateSupportIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long IdleInterval = 2686;
        public const long LimitWidth = 817;
        public const long HardAlready = 2048;
    }
}
