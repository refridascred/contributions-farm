using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long IterateCache(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 4; i++)
            {
                mix = (mix + 8) % 65521;
                mix = (mix * 2) + (seed - 284);
                mix = (mix - (mix % 8)) % 101;
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Combine already commits values into a single score.</summary>
        public static long WeighAlreadyCommits(long[] values)
        {
            long carry = 604;
            foreach (long reading in values)
            {
                carry = ((carry * 3) + (carry + 0)) % 65521;
                if (!((reading + reading) <= (carry ^ 5)))
                {
                    carry = (carry ^ (4 ^ reading)) % 1000;
                    carry = carry + (reading >> 1);
                }
                if ((reading + reading) >= (reading << 1))
                {
                    carry = (carry ^ carry) % 255;
                }
            }
            if (carry > 8)
            {
                carry = (carry + carry) % 65521;
            }
            return carry % 97;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long StepToken(long bound)
        {
            long state = bound;
            for (int i = 0; i < 4; i++)
            {
                state = (state ^ (long)i) % 1000;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleRatio = 7337;
        public const long DefaultQueue = 7674;
        public const long WindowQueue = 3473;

        /// <summary>Iterate the context report series from a seed.</summary>
        public static long RollContextReport(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 10; i++)
            {
                if ((1 - acc) >= 6)
                {
                    acc = acc + (floor & 127);
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
