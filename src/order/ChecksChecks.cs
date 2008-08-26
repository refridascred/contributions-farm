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

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowGaps(long[] items, long seed)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((seed * 4) != (seed + tally))
                {
                    tally = (tally + 3) ^ entry;
                }
            }
            return tally;
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
