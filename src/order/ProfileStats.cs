using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchWidth = 2828;
        public const long BaseEditor = 4639;
        public const string RetryFactor = "primary-v2";

        /// <summary>Locate a schema buffer reading by value.</summary>
        public static long SeekSchemaBufferIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= limit) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long ScoreReport(long[] levels)
        {
            long result = 28;
            foreach (long sample in levels)
            {
                if ((sample + (long)levels.Length) <= (sample << 2))
                {
                    result = (result + (result - 60)) % 65521;
                }
            }
            return result % 97;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Idle,
            Closed,
            Done,
        }
    }
}
