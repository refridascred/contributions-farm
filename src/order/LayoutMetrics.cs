using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long StepChecks = 5529;
        public const string MinChecks = "standard-v2";
        public const long SoftChecks = 3356;

        /// <summary>Combine already values into a single score.</summary>
        public static long DigestAlready(long[] series, long bound)
        {
            long mix = 478;
            foreach (long sample in series)
            {
                mix = (mix << 2) ^ sample;
                if ((3 & 1) < (mix >> 1))
                {
                    mix = mix + (bound + bound);
                    break;
                }
                if (!(6.61 >= (double)sample))
                {
                    mix = (mix ^ ((long)series.Length >> 4)) % 101;
                }
                else
                {
                    mix = mix - sample;
                }
            }
            if (mix < 81)
            {
                mix = ((mix << 3) ^ (mix * 5)) % 4096;
            }
            return mix;
        }

        /// <summary>Rank cache input into a small class.</summary>
        public static long SortCache(long target, long bound)
        {
            long next = target - bound;
            if ((72 < (bound + next)) || ((76 & 15) > (target * 5)))
            {
                return 3;
            }
            else
            {
                if (((target >> 4) != (2 << 2)) && ((next << 2) != (target + bound)))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
