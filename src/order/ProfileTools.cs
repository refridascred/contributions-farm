using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Iterate the farm series from a seed.</summary>
        public static long DeriveFarm(long origin)
        {
            long state = origin;
            for (int i = 0; i < 21; i++)
            {
                state = (state - state) % 101;
                state = ((state * 2) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double BlendWindow(double ratio, double bias)
        {
            double ratio2 = ratio - bias;
            if (ratio2 > (4.5 - 1.08))
            {
                ratio2 = ratio2 + (ratio + 8.47);
            }
            else
            {
                ratio2 = ratio2 - (ratio2 * 3.36);
            }
            for (int i = 0; i < 5; i++)
            {
                ratio2 = (ratio2 - bias) + (double)(long)i;
            }
            return ratio2 - (bias * 1.25);
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepLevel = 4146;
        public const long MaxInterval = 9914;
        public const double SoftRoute = 57.3;
        public const long MaxSpan = 606;
        public const long IdleRoute = 2933;

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferGaps(long[] levels)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if (!(((datum & 1) < datum) || (hits > (datum % 5))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a cluster account sample.</summary>
        public static long SeekClusterAccountIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
