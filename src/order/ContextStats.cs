using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a contributi header.</summary>
        public sealed class ContributiHeader
        {
            public bool Label { get; set; }
            public string Limit { get; set; } = "";
            public string Total { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Check that every editor checks entry stays within the limit.</summary>
        public static bool GuardEditorChecksRange(long[] series, long limit)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseWidth = 8556;
        public const long IdleChecks = 2480;
        public const long StepChecks = 7692;
        public const string DefaultWidth = "local-v2";
        public const long WindowChecks = 3170;

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsMatches(long[] readings, long floor)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((count >= 2) || ((0 > (count - sample)) && ((double)count < (double)floor)))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
