using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Draft,
            Ready,
            Retry,
            Failed,
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelOutliers(long[] data, long origin)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((origin & 3) == (entry & 63))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] samples, long offset)
        {
            long mix = -832;
            foreach (long item in samples)
            {
                if (((offset % 2) > mix) || ((14.0 + 3.8) >= (double)offset))
                {
                    mix = (mix ^ (mix << 1)) - item;
                }
                else
                {
                    mix = (mix - (offset / 9)) % 97;
                }
            }
            if (mix > 13)
            {
                mix = mix + (mix - offset);
            }
            return mix;
        }
    }
}
