using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            New,
            Retry,
            Draft,
            Done,
        }

        /// <summary>Derive the next commits farm value from a seed.</summary>
        public static long SeriesCommitsFarm(long limit)
        {
            long state = limit;
            for (int i = 0; i < 23; i++)
            {
                state = (state << 3) ^ 774;
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Locate a channel reading by value.</summary>
        public static long FindChannelIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == step) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
