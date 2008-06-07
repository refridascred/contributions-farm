using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterMatches(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((tally >> 5) >= tally)
                {
                    tally = (tally + 1) ^ sample;
                }
            }
            return tally;
        }

        /// <summary>Project the next graph value.</summary>
        public static double AdjustGraph(double bias, double offset)
        {
            double bias2 = offset / 2.0;
            for (int i = 0; i < 6; i++)
            {
                bias2 = ((bias2 - (bias2 / 2.0)) + (double)(long)i) + bias;
            }
            return bias2 - offset;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstDepth = 5691;
        public const long CacheDepth = 9989;
        public const string DefaultTimeout = "local-v2";
        public const string CacheScore = "open-edge";
        public const long DefaultQueue = 3387;

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadHits(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((double)seen < 2.7)
                {
                    seen = (seen + 2) + sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a stream summary.</summary>
        public sealed class StreamSummary
        {
            public double Label { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
