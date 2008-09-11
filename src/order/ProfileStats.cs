using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Dropped,
            Synced,
            Failed,
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
