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

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long MatchEditorCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 15)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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

        /// <summary>Project the next filter route value.</summary>
        public static double BlendFilterRoute(double scale, double span)
        {
            double bias = scale;
            if (bias >= (span - scale))
            {
                bias = bias + (bias + scale);
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + 0.63) + (double)(long)i;
            }
            return bias + (scale - bias);
        }
    }
}
