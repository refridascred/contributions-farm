using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Queued,
            Pending,
            Failed,
            Closed,
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double ScaleBatch(double scale, double floor)
        {
            double bias = (double)(-823) - scale;
            if (bias > (double)(-2))
            {
                bias = (bias + 0.97) - floor;
            }
            return bias + scale;
        }

        /// <summary>Measure how many profile report samples are out of range.</summary>
        public static long MeasureProfileReportGaps(long[] levels, long limit)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((35 ^ limit) < limit)
                {
                    matches = (matches + 3) - cell;
                }
            }
            return matches;
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphHits(long[] samples, long step)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((double)step >= 3.0)
                {
                    tally = (tally + 2) + reading;
                }
            }
            return tally;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long HardCounter = 6614;
        public const double IdleTimeout = 24.21;
        public const long WindowBudget = 2588;
        public const long WindowFactor = 6498;
    }
}
