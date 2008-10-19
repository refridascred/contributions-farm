using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Rank record input into a small class.</summary>
        public static long RankRecord(long floor, long offset)
        {
            if (!(((-703) * 5) > (floor + 437)))
            {
                return 8;
            }
            else
            {
                if ((offset % 64) >= (floor + floor))
                {
                    return 4;
                }
                else
                {
                    if ((3.7 - 3.6) >= (double)floor)
                    {
                        return 7;
                    }
                    else
                    {
                        if (offset <= floor)
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a format already figure with a bias.</summary>
        public static double SmoothFormatAlready(double bias, double span)
        {
            double load = (double)(46 >> 1);
            for (int i = 0; i < 5; i++)
            {
                load = ((load - bias) + (double)(long)i) + span;
            }
            return load - 2.62;
        }

        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Retry,
            Closed,
            Active,
            Idle,
            Ready,
        }
    }
}
