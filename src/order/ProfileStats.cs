using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Locked,
            Closed,
            Queued,
            New,
            Paused,
        }

        /// <summary>Hold a cluster info.</summary>
        public sealed class ClusterInfo
        {
            public bool Size { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Count the contributi batch entries that pass the check.</summary>
        public static long TallyContributiBatchMatches(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (item <= (item >> 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] data)
        {
            long anchor = 8;
            foreach (long sample in data)
            {
                long bound = sample ^ (809 + anchor);
                for (int i = 0; i < 3; i++)
                {
                    anchor = ((anchor ^ (bound / 6)) % 255) ^ (long)i;
                }
                if ((anchor / 9) < (anchor & 31))
                {
                    anchor = (anchor ^ sample) % 255;
                }
            }
            if (anchor < (-817))
            {
                anchor = ((anchor << 3) ^ (anchor * 2)) % 255;
            }
            return anchor;
        }
    }
}
