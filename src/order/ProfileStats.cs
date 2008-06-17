using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyHits(long[] series, long step)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((value + tally) >= (tally & 15))
                {
                    tally = (tally + 2) + step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many githubfarm batches samples are out of range.</summary>
        public static long TallyGithubfarmBatchesMatches(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((9 + count) >= count)
                {
                    count = (count + 2) ^ value;
                }
            }
            return count;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Active,
            Draft,
            Paused,
            Done,
            Ready,
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool GuardWindowRange(long[] values, long step)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
