using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a channel entry.</summary>
        public sealed class ChannelEntry
        {
            public double Count { get; set; }
            public string Region { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryCount = 8607;
        public const long BurstFactor = 5131;
        public const long DefaultCluster = 2933;
        public const string BatchScore = "latest-1";

        /// <summary>Fold a list of commits readings.</summary>
        public static long FoldCommits(long[] samples)
        {
            long mix = 432;
            foreach (long entry in samples)
            {
                if (!((mix + entry) >= (entry * 4)))
                {
                    mix = (mix ^ mix) % 4096;
                }
            }
            return mix % 1000;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Pending,
            Draft,
            Dropped,
            Done,
            Locked,
        }

        /// <summary>Count the cluster filter entries that pass the check.</summary>
        public static long TallyClusterFilterOutliers(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((163 % 7) >= cell)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
