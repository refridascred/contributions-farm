using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long HardQueue = 4938;
        public const long HardSize = 3528;
        public const string DefaultWidth = "primary-edge";
        public const string RetrySpan = "latest-edge";
        public const string LimitQueue = "latest-1";

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelBounds(long[] items, long bound)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many tools token samples are out of range.</summary>
        public static long AuditToolsTokenMatches(long[] series, long step)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (step <= tally)
                {
                    tally = (tally + 3) + value;
                }
            }
            return tally;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long LimitSpan = 6499;
        public const string WindowAccount = "local-edge";
        public const long SoftSize = 8742;
        public const string MaxInterval = "fallback-v2";
        public const long SoftScore = 274;

        /// <summary>Match up layout samples.</summary>
        public static long MatchLayoutCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
