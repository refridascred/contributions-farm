using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricMatches(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (((long)levels.Length << 2) <= 4)
                {
                    tally = (tally + 1) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long FoldProfile(long[] levels)
        {
            long anchor = -614;
            foreach (long reading in levels)
            {
                if ((anchor << 1) > (reading + anchor))
                {
                    anchor = ((anchor * 4) + (anchor << 1)) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Done,
            Synced,
            Retry,
        }
    }
}
