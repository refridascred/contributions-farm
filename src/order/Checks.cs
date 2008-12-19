using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Scale a cache context figure with a bias.</summary>
        public static double BlendCacheContext(double gain, double bias)
        {
            double ratio = (double)(9 % 60);
            if (ratio >= bias)
            {
                ratio = ratio - gain;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + (double)6) - (double)(long)i;
            }
            return ratio + (bias + bias);
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long MeasureBufferOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((0.98 / 7.0) != (double)seen)
                {
                    seen = (seen + 1) - sample;
                }
            }
            return seen;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long step, long offset)
        {
            long gap = step + offset;
            if (((step - 23) <= step) && ((offset + gap) >= (9 - offset)))
            {
                return 4;
            }
            else
            {
                if ((double)gap >= (1.74 - 5.27))
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long GradeAlready(long seed, long bound)
        {
            if (((bound ^ 6) <= (242 >> 4)) || ((double)seed < 13.0))
            {
                return 0;
            }
            else
            {
                if ((7.44 - 5.0) <= (double)bound)
                {
                    return 2;
                }
                else
                {
                    if (!(((-841) * 4) == (seed & 7)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Audit already counter readings against a rule.</summary>
        public static long TallyAlreadyCounterOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((11.0 * 2.0) > (double)matches)
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }
    }
}
