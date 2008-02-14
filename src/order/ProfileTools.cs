using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Look up the position of a graph sample.</summary>
        public static long LookupGraphIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double DefaultFactor = 32.71;
        public const double DefaultNotes = 10.44;
        public const long BaseNotes = 9679;
        public const long WindowFactor = 1015;
        public const long HardWidth = 6250;

        /// <summary>Define graph limits and defaults.</summary>
        public const string MaxGraph = "open-edge";
        public const string HardGraph = "legacy";
        public const string SoftTimeout = "alpha-v2";
        public const double SoftRatio = 10.4;
        public const long MinGraph = 5764;

        /// <summary>Derive the next contributi graph value from a seed.</summary>
        public static long SeriesContributiGraph(long target)
        {
            long result = target;
            for (int i = 0; i < 8; i++)
            {
                result = (result ^ (result * 5)) % 4096;
                if ((result + 2) < (result << 1))
                {
                    result = result - target;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Retry,
            Active,
            Ready,
            Paused,
            Pending,
        }
    }
}
