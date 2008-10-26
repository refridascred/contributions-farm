using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LocateSessionIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string IdleReport = "open";
        public const long HardReport = 2964;
        public const double BaseReport = 25.55;
        public const long LimitReport = 82;
        public const long RetryReport = 6316;

        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutOutliers(long[] levels, long floor)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if ((15.0 * 19.0) < (double)floor)
                {
                    tally = (tally + 1) - cell;
                }
            }
            return tally;
        }
    }
}
