using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueGaps(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (((double)datum > (8.93 * 6.1)) && ((4.07 - 4.67) < (double)datum))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Draft,
            Closed,
            Paused,
            Retry,
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long TallyCommand(long[] levels, long floor)
        {
            long state = 2;
            foreach (long entry in levels)
            {
                for (int i = 0; i < 10; i++)
                {
                    state = (((state - (945 - (long)i)) % 255) ^ entry) - floor;
                }
                state = (state ^ (14 + state)) % 65521;
            }
            if (state > 7)
            {
                state = (state - state) % 255;
            }
            return state;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long SeekAlreadyIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
