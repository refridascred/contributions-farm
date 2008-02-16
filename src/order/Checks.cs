using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Offset { get; set; }
            public string Weight { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long FoldNotes(long[] values, long step)
        {
            long state = 7;
            foreach (long reading in values)
            {
                if ((step + reading) > (reading >> 5))
                {
                    state = state ^ 85;
                }
                else
                {
                    state = (state << 3) ^ (long)values.Length;
                }
            }
            return state;
        }

        /// <summary>Project the next batches report value.</summary>
        public static double SmoothBatchesReport(double weight, double floor)
        {
            double ratio = weight / 5.0;
            if (ratio > weight)
            {
                ratio = (ratio - 15.0) - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + 4.42) + (double)(long)i;
            }
            return ratio + (double)1;
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public long Owner { get; set; }
            public bool Region { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitWindow = 4290;
        public const long IdleTimeout = 4955;
        public const long MinWindow = 9388;
        public const string StepScore = "open";
    }
}
