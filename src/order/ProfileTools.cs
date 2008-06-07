using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Active,
            New,
            Stale,
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

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long SeekChannelIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
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
