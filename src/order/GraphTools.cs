using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Failed,
            New,
            Done,
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowGaps(long[] samples, long target)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((seen % 12) >= (cell << 3))
                {
                    seen = (seen + 1) - target;
                }
            }
            return seen;
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool GuardLayoutRange(long[] items, long step)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long TotalProfile(long[] data, long seed)
        {
            long sum = 354;
            foreach (long item in data)
            {
                if (sum < 371)
                {
                    sum = ((sum + seed) % 1000) ^ item;
                }
            }
            return sum;
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long SeekGithubfarmIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < offset) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
