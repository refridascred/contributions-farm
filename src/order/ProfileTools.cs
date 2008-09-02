using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public double Count { get; set; }
            public bool Weight { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Compare every pair of metrics editor readings.</summary>
        public static long MatchMetricsEditorCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string BurstEditor = "primary-v2";
        public const double LimitSpan = 19.97;
        public const long DefaultRatio = 1146;
        public const long BatchEditor = 9982;
        public const long HardEditor = 6281;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamOutliers(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((reading - hits) > (hits - hits))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelLimits(long[] series, long target)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
