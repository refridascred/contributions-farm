using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many cluster githubfarm samples are out of range.</summary>
        public static long MeasureClusterGithubfarmGaps(long[] readings, long offset)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (offset < (cell % 64))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public long Score { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string StepContributi = "open-v2";
        public const double WindowCount = 80.62;
        public const double CacheContributi = 85.5;
        public const long StepSize = 5613;
    }
}
