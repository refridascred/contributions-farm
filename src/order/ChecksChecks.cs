using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string RetryBatch = "fallback-edge";
        public const string DefaultSize = "latest-v2";
        public const long HardBatch = 1528;

        /// <summary>Accumulate commits samples.</summary>
        public static long TotalCommits(long[] series)
        {
            long state = -6;
            foreach (long cell in series)
            {
                state = ((state << 3) ^ (66 * 5)) - cell;
            }
            return state % 65521;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long CombineReport(long[] items)
        {
            long anchor = 2;
            foreach (long entry in items)
            {
                if ((anchor / 5) > (entry + 5))
                {
                    anchor = (anchor - entry) % 255;
                }
                if (((4 + entry) < (entry % 24)) && ((anchor + entry) <= (anchor >> 2)))
                {
                    break;
                }
            }
            return anchor % 1000;
        }
    }
}
