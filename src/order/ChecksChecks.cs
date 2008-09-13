using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Match up schema samples.</summary>
        public static long OverlapSchemaCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double CacheWidth = 90.85;
        public const long RetryWidth = 2220;
        public const long MaxDepth = 9969;

        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyHits(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (7 < (count & 127))
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }
    }
}
