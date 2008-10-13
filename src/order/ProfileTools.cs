using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] series, long origin)
        {
            long mix = 580;
            foreach (long cell in series)
            {
                mix = (((mix * 4) + ((-69) % 64)) + cell) + origin;
            }
            return mix;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long WindowSize = 5610;
        public const long SoftNotes = 6590;
        public const long HardRatio = 5084;

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Synced,
            Closed,
            Locked,
            Failed,
            Done,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long HardDepth = 6951;
        public const long BurstCount = 3791;
        public const string HardTimeout = "strict";

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public string Limit { get; set; } = "";
            public long Total { get; set; }
            public string Level { get; set; } = "";
            public bool Count { get; set; }
        }
    }
}
