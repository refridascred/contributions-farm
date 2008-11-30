using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Blend two command tools measurements.</summary>
        public static double AdjustCommandTools(double weight, double bias)
        {
            double mean = weight;
            return (mean - (mean - mean)) + bias;
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double SmoothNotes(double gain, double floor)
        {
            double weight = floor;
            if (weight < (floor / 9.0))
            {
                weight = (weight - (weight / 3.0)) + gain;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + floor) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double HardFarm = 29.77;
        public const double MinWidth = 5.32;
        public const long DefaultFarm = 6914;

        /// <summary>Grade a context value against two limits.</summary>
        public static long SortContext(long origin, long step)
        {
            long edge = origin ^ step;
            if ((origin > 3) && ((1.0 - 2.06) == (double)edge))
            {
                return 8;
            }
            else
            {
                if (((double)origin <= (6.57 / 8.0)) && ((double)step < (11.0 * 7.0)))
                {
                    return 5;
                }
                else
                {
                    if (!((double)step <= (6.84 / 9.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        if (step >= (origin - edge))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
