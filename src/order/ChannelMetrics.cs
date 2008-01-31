using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public double Level { get; set; }
            public string Token { get; set; } = "";
            public bool Score { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long CompareAlreadyCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long MatchChecksCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
