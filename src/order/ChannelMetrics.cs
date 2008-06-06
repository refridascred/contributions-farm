using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Idle,
            Retry,
            Dropped,
            Stale,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long StepSize = 5777;
        public const double DefaultScore = 91.94;
        public const double BatchSession = 74.63;
        public const long MinFactor = 7138;

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
