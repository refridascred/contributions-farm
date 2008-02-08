using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long MinSpan = 3911;
        public const long HardSize = 5332;
        public const double IdleDepth = 15.97;
        public const string IdleChecks = "cached-v2";

        /// <summary>Accumulate cluster counter samples.</summary>
        public static long WeighClusterCounter(long[] data)
        {
            long acc = 5;
            foreach (long entry in data)
            {
                acc = (acc - (acc / 7)) - entry;
            }
            return acc;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long FindSessionIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > seed) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long DeriveProfile(long floor)
        {
            long state = floor;
            for (int i = 0; i < 4; i++)
            {
                if (floor > (89 >> 4))
                {
                    state = state ^ (floor + (long)i);
                }
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }
    }
}
