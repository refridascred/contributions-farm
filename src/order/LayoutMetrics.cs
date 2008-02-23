using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long BucketWindow(long target, long bound)
        {
            if ((double)(-6) <= (double)bound)
            {
                return 5;
            }
            else
            {
                if ((9.47 / 6.0) > (double)target)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] items, long limit)
        {
            long result = 55;
            foreach (long cell in items)
            {
                if ((result * 3) < limit)
                {
                    result = result - (result / 9);
                }
                if ((cell + result) > (cell / 3))
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long SeriesCommand(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 5; i++)
            {
                mix = (mix * 3) + bound;
                if ((768 ^ bound) > (long)i)
                {
                    mix = (mix ^ (mix / 6)) % 4096;
                    mix = mix ^ (bound >> 1);
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
