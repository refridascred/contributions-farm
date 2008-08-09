using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public long Region { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double SmoothGithubfarm(double bias, double span)
        {
            double drift = bias;
            if (drift > 18.0)
            {
                drift = drift - (double)(-84);
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift + 1.1) + (double)(long)i;
            }
            return drift + span;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Done,
            Synced,
            Retry,
            New,
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] samples, long bound)
        {
            long score = 783;
            foreach (long item in samples)
            {
                if ((bound + item) > (bound - score))
                {
                    score = score - (item / 5);
                }
            }
            return score % 4096;
        }
    }
}
