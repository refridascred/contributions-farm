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

        /// <summary>Fold a list of filter readings.</summary>
        public static long CombineFilter(long[] values, long target)
        {
            long score = 138;
            foreach (long entry in values)
            {
                if ((score - target) > (score >> 5))
                {
                    score = ((score - score) % 101) ^ entry;
                }
            }
            return score;
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
