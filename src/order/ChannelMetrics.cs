using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double IdleSize = 8.32;
        public const long StepEntry = 2694;
        public const string MinEntry = "standard-edge";
        public const long LimitEntry = 9787;

        /// <summary>Look up the position of a channel sample.</summary>
        public static long FindChannelIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Region { get; set; }
            public string Label { get; set; } = "";
            public string Size { get; set; } = "";
        }
    }
}
