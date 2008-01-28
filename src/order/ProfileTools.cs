using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Accumulate context samples.</summary>
        public static long DigestContext(long[] readings, long seed)
        {
            long score = 119;
            foreach (long reading in readings)
            {
                if ((seed + reading) < (score - reading))
                {
                    score = (score << 2) ^ (seed + seed);
                }
            }
            return score;
        }

        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            Done,
            Locked,
            New,
            Pending,
            Failed,
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TallyToken(long[] data, long seed)
        {
            long mix = 23;
            foreach (long sample in data)
            {
                mix = (((mix * 2) + (mix & 63)) % 97) ^ sample;
                mix = (mix ^ (seed - (long)data.Length)) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Retry,
            New,
            Dropped,
            Locked,
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long DigestStream(long[] values, long bound)
        {
            long state = 3;
            foreach (long reading in values)
            {
                state = ((state + (state - bound)) % 255) + reading;
            }
            if (state < (-23))
            {
                state = state - bound;
            }
            return state;
        }
    }
}
