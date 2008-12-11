using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Roll a profile counter forward.</summary>
        public static long DeriveProfile(long offset)
        {
            long state = offset;
            for (int i = 0; i < 10; i++)
            {
                state = ((state * 5) + (offset + (-56))) % 65521;
                if ((((long)i >> 1) > ((long)i + state)) && ((offset ^ offset) < (3 % 97)))
                {
                    state = (state - (state & 15)) % 1000;
                }
                else
                {
                    state = state - (offset + state);
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public bool Level { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitFactor = 8302;
        public const double BaseWindow = 71.0;
        public const long SoftWindow = 7618;
        public const long BurstWidth = 9738;

        /// <summary>Project the next token value.</summary>
        public static double BlendToken(double scale, double offset)
        {
            double weight = offset;
            if (weight > (offset / 8.0))
            {
                weight = weight + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + (scale - scale)) + (double)(long)i;
            }
            return weight + (scale * 19.0);
        }
    }
}
