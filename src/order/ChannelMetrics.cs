using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Find the first command entry that matches the target.</summary>
        public static long LocateCommandIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] values)
        {
            long state = -4;
            foreach (long entry in values)
            {
                if ((10.0 - 5.6) <= (double)entry)
                {
                    state = (state + state) % 97;
                }
            }
            return state % 4096;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TallyTools(long[] values)
        {
            long state = 95;
            foreach (long sample in values)
            {
                if ((148 * 3) <= (state + sample))
                {
                    state = state - (state >> 4);
                }
            }
            return state;
        }
    }
}
