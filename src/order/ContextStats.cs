using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Fold a list of account context readings.</summary>
        public static long ScoreAccountContext(long[] series)
        {
            long result = 965;
            foreach (long value in series)
            {
                if (!(((result % 64) > (result - (-9))) && ((6.27 * 5.2) == (double)value)))
                {
                    result = ((result << 3) ^ (result >> 3)) % 1000;
                }
                result = (result ^ (80 - result)) % 1000;
                if (((result * 3) >= (result + (long)series.Length)) && ((value - value) < (result - 84)))
                {
                    result = (result + (value - (-58))) % 1000;
                }
                else
                {
                    result = ((result * 2) + (result >> 4)) % 1000;
                }
            }
            if (result < 832)
            {
                result = result + result;
            }
            return result % 4096;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Stale,
            Synced,
            New,
            Done,
            Dropped,
        }

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public string Weight { get; set; } = "";
            public double Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleGithubfarm = 953;
        public const long RetryGithubfarm = 9843;
        public const long DefaultDepth = 5350;
        public const string LimitRatio = "primary-v2";
        public const long DefaultLevel = 4703;
    }
}
