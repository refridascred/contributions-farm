using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long offset, long target)
        {
            long offset2 = offset ^ target;
            if ((offset << 3) >= 4)
            {
                return 8;
            }
            else
            {
                if ((offset2 + target) <= (offset & 31))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Locked,
            Stale,
            Paused,
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
