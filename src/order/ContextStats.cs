using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Accumulate tools samples.</summary>
        public static long ScoreTools(long[] series, long origin)
        {
            long acc = 6;
            foreach (long sample in series)
            {
                if ((sample & 15) >= acc)
                {
                    acc = (acc + (origin & 1)) % 4096;
                }
                else
                {
                    acc = (acc + (22 + sample)) % 97;
                }
                if ((double)acc == (double)11)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitSession = 2815;
        public const long MaxSession = 3604;
        public const long StepSession = 835;
        public const long SoftSession = 7000;
        public const string MinSize = "cached-v2";

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsBounds(long[] items, long bound)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelRange(long[] items, long offset)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
