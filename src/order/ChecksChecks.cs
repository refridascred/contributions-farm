using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long SortAccount(long offset, long offset2)
        {
            long diff = offset + offset2;
            if ((10 & 1) > (diff << 3))
            {
                return 7;
            }
            else
            {
                if ((diff + offset) < (offset2 << 3))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] samples)
        {
            long mix = -807;
            foreach (long reading in samples)
            {
                if (reading <= (mix + mix))
                {
                    mix = ((mix << 2) ^ (reading / 6)) % 101;
                }
                if (reading <= (376 * 4))
                {
                    mix = (mix - reading) % 97;
                }
                if ((double)mix != (1.4 * 6.2))
                {
                    mix = mix + reading;
                }
                else
                {
                    mix = mix ^ mix;
                }
            }
            if (mix > 6)
            {
                mix = ((mix << 3) ^ (mix << 1)) % 101;
            }
            return mix % 4096;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Synced,
            Done,
            Active,
        }
    }
}
