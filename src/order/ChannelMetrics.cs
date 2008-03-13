using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public double Size { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long GradeContext(long bound, long step)
        {
            if ((bound + bound) < (9 % 100))
            {
                return 2;
            }
            else
            {
                if (bound <= (bound ^ bound))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
