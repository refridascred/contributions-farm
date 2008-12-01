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

        /// <summary>Roll a report counter forward.</summary>
        public static long DeriveReport(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 15; i++)
            {
                mark = mark + ((long)i + mark);
                if ((mark >> 3) < (mark / 2))
                {
                    mark = mark - mark;
                    continue;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }
    }
}
