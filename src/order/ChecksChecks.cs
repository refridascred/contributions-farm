using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryFilter = 8578;
        public const long HardFilter = 8606;
        public const long MaxCount = 7971;
        public const long DefaultFilter = 5693;

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryOutliers(long[] series, long floor)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if (7.2 > (double)item)
                {
                    tally = (tally + 1) - floor;
                }
            }
            return tally;
        }

        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
