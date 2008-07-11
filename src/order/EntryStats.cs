using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public double Owner { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double MinDepth = 24.18;
        public const long BurstRatio = 9176;
        public const long BatchCluster = 9566;
        public const long StepSize = 3392;
        public const double MinCluster = 72.7;

        /// <summary>Define metric limits and defaults.</summary>
        public const double HardSize = 20.66;
        public const string SoftMetric = "open-v2";
        public const string HardMetric = "local-v2";
        public const long StepBudget = 800;

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Ready,
            Paused,
            Closed,
        }

        /// <summary>Count commits graph pairs that satisfy a relation.</summary>
        public static long PairCommitsGraphCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
