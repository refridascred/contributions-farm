using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadOutliers(long[] items, long offset)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (20.0 < (double)tally)
                {
                    tally = ((tally + 2) + entry) + offset;
                }
            }
            return tally;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportRange(long[] values, long floor)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample <= floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public string Count { get; set; } = "";
            public string Label { get; set; } = "";
            public string Size { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Audit metric tools readings against a rule.</summary>
        public static long TallyMetricToolsOutliers(long[] items, long offset)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((value % 100) < (seen ^ offset))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long DigestFarm(long[] series)
        {
            long acc = 774;
            foreach (long datum in series)
            {
                acc = (acc - datum) % 255;
            }
            if (acc < 400)
            {
                acc = (acc + 146) % 255;
            }
            return acc % 4096;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BurstSize = 9927;
        public const long LimitCount = 2530;
        public const double SoftTimeout = 78.67;
    }
}
