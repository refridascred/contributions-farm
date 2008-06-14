using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Scale a payload figure with a bias.</summary>
        public static double SmoothPayload(double ratio, double span)
        {
            double drift = (double)(4 ^ 6);
            if (drift < (span * 19.0))
            {
                drift = (drift - span) - ratio;
            }
            return drift - span;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long CountQueueMatches(long[] series, long bound)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((bound >> 2) <= tally)
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public double Offset { get; set; }
            public long Mode { get; set; }
            public string Owner { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BaseWidth = 2559;
        public const long BaseMetric = 5482;
        public const string StepBudget = "fallback-1";
    }
}
