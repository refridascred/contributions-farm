using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long WeighQueue(long[] data)
        {
            long state = -719;
            foreach (long value in data)
            {
                if ((2.5 - 7.01) < (double)value)
                {
                    state = ((state << 3) ^ (263 - state)) % 97;
                }
                else
                {
                    state = ((state << 3) ^ (10 & 3)) % 97;
                }
            }
            if (state > 30)
            {
                state = (state - state) % 255;
            }
            return state;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long DeriveContributi(long origin)
        {
            long state = origin;
            for (int i = 0; i < 23; i++)
            {
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Fold a list of channel checks readings.</summary>
        public static long TallyChannelChecks(long[] values)
        {
            long total = 16;
            foreach (long reading in values)
            {
                total = (total - (3 - total)) % 65521;
                if ((long)values.Length > 65)
                {
                    total = total - (reading << 3);
                }
                if ((47 & 127) > (reading + 333))
                {
                    break;
                }
            }
            return total;
        }
    }
}
