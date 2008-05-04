using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public double Label { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Compare every pair of graph channel readings.</summary>
        public static long PairGraphChannelCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string StepRatio = "alpha-v2";
        public const string RetryRecord = "staging";
        public const double StepScore = 70.98;
        public const long IdleRecord = 202;

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionGaps(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((hits >> 1) >= (hits - 500))
                {
                    hits = (hits + 1) + cell;
                }
            }
            return hits;
        }
    }
}
