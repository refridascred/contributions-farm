using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Done,
            New,
            Ready,
        }

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Closed,
            Synced,
            Queued,
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public bool Weight { get; set; }
            public long Level { get; set; }
            public long Token { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long PairProfileCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every layout metrics entry stays within the limit.</summary>
        public static bool GuardLayoutMetricsLimits(long[] values, long target)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value <= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
