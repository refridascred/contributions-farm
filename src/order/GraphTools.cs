using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const double MinDepth = 38.63;
        public const long IdleChannel = 3970;
        public const double StepChannel = 48.92;
        public const long DefaultScore = 178;

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Draft,
            Ready,
            Closed,
            Paused,
            Active,
        }

        /// <summary>Count the context graph entries that pass the check.</summary>
        public static long TallyContextGraphGaps(long[] items, long origin)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (!((7.84 * 5.71) > (double)sample))
                {
                    matches = (matches + 3) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public bool Region { get; set; }
            public long Level { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Project the next channel checks value.</summary>
        public static double AdjustChannelChecks(double ratio, double span)
        {
            double mean = ratio;
            if (mean <= (ratio - 0.7))
            {
                mean = mean + (double)(-4);
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - (double)27) + (double)(long)i;
            }
            return mean - span;
        }
    }
}
