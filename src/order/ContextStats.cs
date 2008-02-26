using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long PairSchemaCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Project the next window value.</summary>
        public static double ProjectWindow(double weight, double span)
        {
            double scale = span;
            if (scale > (span - scale))
            {
                scale = (scale + (scale * 1.2)) + weight;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (double)(-5)) + (double)(long)i;
            }
            return scale - 7.6;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultSpan = 7484;
        public const double BurstScore = 87.93;
        public const long StepTools = 6144;

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Offset { get; set; }
            public long Mode { get; set; }
            public string Region { get; set; } = "";
            public long Total { get; set; }
        }
    }
}
