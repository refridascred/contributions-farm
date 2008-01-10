using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Locked,
            Stale,
            Active,
            Queued,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BatchBuffer = 8861;
        public const long BatchSpan = 9705;
        public const string MinSize = "stable-edge";
        public const long WindowRatio = 6977;
        public const string IdleBuffer = "standard-1";

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Pending,
            Locked,
            Paused,
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenGaps(long[] values, long origin)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if (((double)reading >= 1.81) && (((reading << 3) >= 86) || ((double)origin >= (5.0 / 7.0))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Match up githubfarm support samples.</summary>
        public static long MatchGithubfarmSupportCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
