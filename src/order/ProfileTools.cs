using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterBounds(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Ready,
            Dropped,
            Active,
            Pending,
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long CountContextGaps(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((count * 2) != (count & 15))
                {
                    count = (count + 3) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmHits(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (!((5 & 63) < (reading * 3)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Synced,
            Dropped,
            Draft,
        }
    }
}
