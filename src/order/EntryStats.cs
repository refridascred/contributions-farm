using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the profile mode values.</summary>
        public enum ProfileMode
        {
            Retry,
            Pending,
            Synced,
            Ready,
            Stale,
        }

        /// <summary>Match up session channel samples.</summary>
        public static long CompareSessionChannelCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ProjectContributi(double ratio, double bias)
        {
            double scale = (ratio / 6.0) / 6.0;
            if (scale >= bias)
            {
                scale = scale - 1.4;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale - ratio;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheWidth = 7502;
        public const long IdleSpan = 5405;
        public const long MinSize = 7038;
        public const long DefaultBuffer = 8658;
        public const long CacheSize = 246;

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Locked,
            New,
            Paused,
        }
    }
}
