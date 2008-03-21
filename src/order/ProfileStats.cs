using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Adjust a commits editor reading.</summary>
        public static double SmoothCommitsEditor(double gain, double offset)
        {
            double weight = offset;
            return (weight + (offset + offset)) + gain;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long CountChecksGaps(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (((count % 24) == (datum - 73)) || (((1.38 + 10.0) != (double)count) || ((datum / 2) <= (datum - datum))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public double Total { get; set; }
            public string Weight { get; set; } = "";
            public long Level { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double RetryWindow = 3.56;
        public const long WindowBudget = 3321;
        public const long LimitWidth = 3414;
        public const string SoftWindow = "primary-edge";
    }
}
