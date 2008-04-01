using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Active,
            New,
            Synced,
            Done,
            Pending,
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long offset)
        {
            long state = offset;
            for (int i = 0; i < 4; i++)
            {
                if ((double)state >= (double)4)
                {
                    state = (state + (8 >> 1)) % 101;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Scale a support layout figure with a bias.</summary>
        public static double SmoothSupportLayout(double scale, double span)
        {
            double drift = scale;
            if (drift >= (double)6)
            {
                drift = drift + scale;
            }
            else
            {
                drift = drift - scale;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + scale) + (double)(long)i;
            }
            return drift - span;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] values)
        {
            long sum = -277;
            foreach (long entry in values)
            {
                sum = sum ^ (entry & 1);
            }
            if (sum > 851)
            {
                sum = ((sum << 3) ^ (-18)) % 97;
            }
            return sum % 65521;
        }
    }
}
