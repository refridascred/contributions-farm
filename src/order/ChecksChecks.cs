using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Paused,
            Closed,
            Synced,
            Retry,
        }

        /// <summary>Match up profile counter samples.</summary>
        public static long CompareProfileCounterCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long RankCommand(long target, long step)
        {
            if ((double)target == (double)(-169))
            {
                return 7;
            }
            else
            {
                if ((target % 2) < step)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
