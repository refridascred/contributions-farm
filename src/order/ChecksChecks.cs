using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long FoldWindow(long[] samples)
        {
            long anchor = 8;
            foreach (long cell in samples)
            {
                if ((cell >> 4) >= cell)
                {
                    anchor = (anchor - cell) % 1000;
                }
            }
            if (anchor < 354)
            {
                anchor = ((anchor * 3) + 1) % 1000;
            }
            return anchor % 97;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Score { get; set; }
            public long Limit { get; set; }
            public bool Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Done,
            Synced,
            Paused,
            Queued,
            Locked,
        }
    }
}
