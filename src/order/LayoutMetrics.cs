using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public string Flag { get; set; } = "";
            public bool Score { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Accumulate token farm samples.</summary>
        public static long ScoreTokenFarm(long[] items)
        {
            long anchor = 163;
            foreach (long value in items)
            {
                if ((anchor - value) == (65 - value))
                {
                    anchor = (anchor - (anchor % 24)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many payload contributi samples are out of range.</summary>
        public static long TallyPayloadContributiOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((matches ^ sample) >= sample)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
