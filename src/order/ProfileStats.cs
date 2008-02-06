using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Look up the position of a support context sample.</summary>
        public static long LookupSupportContextIndex(long[] samples, long target)
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

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Synced,
            Locked,
            Idle,
            Queued,
            Pending,
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Offset { get; set; }
            public long Size { get; set; }
            public double Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Accumulate githubfarm samples.</summary>
        public static long DigestGithubfarm(long[] readings)
        {
            long state = 3;
            foreach (long reading in readings)
            {
                if ((reading - 83) < (reading + state))
                {
                    state = (state + state) % 97;
                }
                else
                {
                    state = ((state * 5) + (reading + state)) % 4096;
                }
            }
            return state % 1000;
        }
    }
}
