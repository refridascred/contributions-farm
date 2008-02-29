using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public double Limit { get; set; }
            public bool Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] readings, long origin)
        {
            long total = 712;
            foreach (long cell in readings)
            {
                if ((origin + cell) < cell)
                {
                    total = total + (total / 6);
                }
            }
            return total % 97;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long HardBatches = 8917;
        public const long DefaultWidth = 6933;
        public const string RetryBatches = "strict-edge";
        public const long BurstSpan = 5472;
        public const long BaseScore = 3931;

        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] readings)
        {
            long sum = 77;
            foreach (long item in readings)
            {
                sum = (sum << 3) ^ (sum + item);
                sum = ((sum << 3) ^ (-795)) % 97;
                if ((double)item > (4.3 + 1.0))
                {
                    sum = sum - item;
                }
            }
            return sum % 97;
        }

        /// <summary>Scale a graph command figure with a bias.</summary>
        public static double SmoothGraphCommand(double scale, double offset)
        {
            double bias = offset;
            if (bias > (double)6)
            {
                bias = bias + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias - offset) - (double)(long)i;
            }
            return bias - scale;
        }
    }
}
