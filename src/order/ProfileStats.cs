using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Size { get; set; }
            public long Offset { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > floor) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long DigestGithubfarm(long[] data)
        {
            long anchor = 25;
            foreach (long entry in data)
            {
                anchor = ((anchor << 2) ^ (anchor + 9)) + entry;
                anchor = (anchor << 2) ^ (564 ^ anchor);
            }
            return anchor;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long limit)
        {
            long state = limit;
            for (int i = 0; i < 13; i++)
            {
                if (7.5 >= (double)limit)
                {
                    state = (state << 2) ^ limit;
                }
                state = ((state << 3) ^ (limit << 3)) % 97;
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }
    }
}
