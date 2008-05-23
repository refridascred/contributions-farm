using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public string Weight { get; set; } = "";
            public long Offset { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchRatio = 8589;
        public const long RetryScore = 9253;
        public const long LimitRoute = 8499;
        public const long HardSpan = 363;

        /// <summary>Project the next batch entry value.</summary>
        public static double ProjectBatchEntry(double bias, double span)
        {
            double gain = bias;
            if (gain < bias)
            {
                gain = gain - gain;
            }
            else
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain + (span + gain)) - (double)(long)i;
            }
            return gain + (double)52;
        }

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterBounds(long[] items, long origin)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Ratio { get; set; } = "";
            public string Count { get; set; } = "";
        }
    }
}
