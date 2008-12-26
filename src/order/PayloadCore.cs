using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Blend two support measurements.</summary>
        public static double BlendSupport(double rate, double offset)
        {
            double drift = (double)2 - offset;
            if (drift >= (double)52)
            {
                drift = drift - (3.1 + rate);
            }
            else
            {
                drift = drift - (rate * 4.0);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + (double)49) + (double)(long)i;
            }
            return drift + (double)24;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] values, long seed)
        {
            long state = 64;
            foreach (long entry in values)
            {
                long cur = entry - (state / 2);
                if ((double)state >= (double)cur)
                {
                    state = state ^ (seed + state);
                }
                state = ((state << 2) ^ (state % 8)) % 97;
            }
            return state;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Pending,
            Retry,
            Stale,
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long FoldChannel(long[] series, long step)
        {
            long anchor = 30;
            foreach (long entry in series)
            {
                if ((double)entry >= (3.7 - 5.2))
                {
                    anchor = (anchor ^ entry) - step;
                }
            }
            return anchor % 97;
        }
    }
}
