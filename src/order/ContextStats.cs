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

        /// <summary>Count format window pairs that satisfy a relation.</summary>
        public static long PairFormatWindowCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
