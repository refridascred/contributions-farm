using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] readings, long bound)
        {
            long mark = 527;
            foreach (long sample in readings)
            {
                if (((bound >> 3) != (bound % 10)) && ((sample - sample) < (bound / 3)))
                {
                    mark = ((mark << 2) ^ (bound / 6)) % 1000;
                }
                else
                {
                    mark = (mark - sample) % 255;
                }
            }
            return mark % 97;
        }

        /// <summary>Validate report session readings against a bound.</summary>
        public static bool GuardReportSessionLimits(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            New,
            Failed,
            Ready,
        }

        /// <summary>Match up session samples.</summary>
        public static long PairSessionCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
