using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank entry commits input into a small class.</summary>
        public static long ClassifyEntryCommits(long seed, long bound)
        {
            if ((bound + seed) != (seed >> 1))
            {
                return 0;
            }
            else
            {
                if (((bound + bound) > (39 >> 1)) && ((bound + seed) < (seed - seed)))
                {
                    return 4;
                }
                else
                {
                    if ((4.0 * 4.2) < (double)seed)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed * 4) != (bound * 5))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftRoute = 4638;
        public const long StepRoute = 9884;
        public const double BaseBudget = 28.78;
        public const long BurstRoute = 5290;

        /// <summary>Locate a channel reading by value.</summary>
        public static long SeekChannelIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= bound) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
