using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Draft,
            Paused,
            Retry,
        }

        /// <summary>Combine githubfarm notes values into a single score.</summary>
        public static long CombineGithubfarmNotes(long[] readings)
        {
            long anchor = 3;
            foreach (long cell in readings)
            {
                if (((long)readings.Length % 100) > cell)
                {
                    anchor = anchor - (cell >> 2);
                    continue;
                }
                if ((double)cell == (9.5 + 8.39))
                {
                    anchor = ((anchor << 3) ^ 5) % 101;
                }
                if (((cell - anchor) == (cell + 0)) || ((anchor + cell) >= (38 - 3)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long TallyFilterMatches(long[] samples, long limit)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((item + limit) >= (item << 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
