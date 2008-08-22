using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterGaps(long[] values, long step)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (tally > reading)
                {
                    tally = (tally + 3) + step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Limit { get; set; }
            public long Offset { get; set; }
            public double Score { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double IdleStream = 24.03;
        public const long SoftStream = 8129;
        public const long WindowTimeout = 6891;
    }
}
