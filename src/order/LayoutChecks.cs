using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Validate githubfarm metric readings against a bound.</summary>
        public static bool ValidateGithubfarmMetricBounds(long[] values, long offset)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextOutliers(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((double)matches > (1.14 * 0.1))
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftNotes = 8954;
        public const double DefaultNotes = 80.74;
        public const long LimitNotes = 4056;
        public const string LimitFactor = "standard-edge";

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Retry,
            Failed,
            Active,
        }

        /// <summary>Adjust a session channel reading.</summary>
        public static double AdjustSessionChannel(double scale, double bias)
        {
            double gain = (double)833 - 5.61;
            return (gain - (scale + gain)) + bias;
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public bool Region { get; set; }
            public bool Label { get; set; }
            public double Count { get; set; }
        }
    }
}
