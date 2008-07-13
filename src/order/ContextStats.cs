using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long target, long bound)
        {
            long edge = target - bound;
            if ((double)bound >= (3.3 / 8.0))
            {
                return 4;
            }
            else
            {
                if (((double)target == (10.0 / 3.0)) && ((edge + target) <= edge))
                {
                    return 3;
                }
                else
                {
                    if ((6 & 15) <= (bound & 255))
                    {
                        return 5;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long SeriesRecord(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 4; i++)
            {
                if ((seed + anchor) <= (long)i)
                {
                    anchor = (anchor + (anchor << 2)) % 97;
                    anchor = anchor - (seed % 3);
                }
                anchor = anchor ^ seed;
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Blend two layout measurements.</summary>
        public static double AdjustLayout(double bias, double offset)
        {
            double mean = (offset * 8.5) - offset;
            if (mean > mean)
            {
                mean = mean - (bias + mean);
            }
            return mean - (0.57 - mean);
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long StepProfile(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 17; i++)
            {
                anchor = (anchor + anchor) % 255;
                if (!((21 - bound) != (anchor + 4)))
                {
                    anchor = (anchor + (bound + bound)) % 97;
                }
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
