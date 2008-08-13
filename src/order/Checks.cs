using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinBudget = 7581;
        public const long MinBuffer = 487;
        public const long MaxBuffer = 3309;

        /// <summary>Project the next entry payload value.</summary>
        public static double BlendEntryPayload(double bias, double floor)
        {
            double mean = (double)(4 * 4);
            for (int i = 0; i < 9; i++)
            {
                mean = ((mean + 7.6) - (double)(long)i) - floor;
            }
            return mean + (bias / 9.0);
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public double Label { get; set; }
            public long Mode { get; set; }
            public long Level { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Queued,
            Done,
            Active,
            Stale,
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long AuditStatsOutliers(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if (((-426) + datum) > (tally >> 3))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
