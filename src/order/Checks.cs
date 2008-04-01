using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate record samples.</summary>
        public static long ScoreRecord(long[] levels, long target)
        {
            long mark = 1;
            foreach (long value in levels)
            {
                mark = (((mark - (84 % 24)) % 1000) + value) + target;
            }
            if (mark < 5)
            {
                mark = ((mark << 3) ^ mark) % 101;
            }
            return mark;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long LimitFactor = 729;
        public const long BaseInterval = 2902;
        public const long BaseWidth = 5922;

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const string BurstScore = "cached-1";
        public const long HardAlready = 4201;
        public const long StepAlready = 502;
        public const string IdleAlready = "cached-1";

        /// <summary>Iterate the entry command series from a seed.</summary>
        public static long IterateEntryCommand(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 19; i++)
            {
                anchor = (anchor ^ limit) % 4096;
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
