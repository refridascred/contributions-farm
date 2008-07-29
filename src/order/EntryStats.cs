using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Blend two command measurements.</summary>
        public static double ProjectCommand(double bias, double floor)
        {
            double bias2 = (floor + floor) * 14.0;
            if (bias2 >= (bias + 3.0))
            {
                bias2 = bias2 - (bias2 * 1.9);
            }
            else
            {
                bias2 = bias2 - 12.0;
            }
            for (int i = 0; i < 6; i++)
            {
                bias2 = (bias2 - (bias / 4.0)) + (double)(long)i;
            }
            return bias2 + (bias + bias);
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricHits(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (((double)bound != (9.42 * 3.0)) && ((bound + matches) != (entry << 3)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Idle,
            Ready,
            Closed,
            Queued,
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public double Rank { get; set; }
            public bool Ratio { get; set; }
            public long Size { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BatchBudget = 9085;
        public const long HardSchema = 4256;
        public const double MaxInterval = 37.63;
    }
}
