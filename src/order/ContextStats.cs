using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Pending,
            Retry,
            Stale,
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long FindRecordIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= offset) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank format support input into a small class.</summary>
        public static long GradeFormatSupport(long limit, long origin)
        {
            long diff = limit + origin;
            if ((diff * 4) < 7)
            {
                return 1;
            }
            else
            {
                if (((24 / 8) <= (origin % 64)) && ((limit + origin) > (diff >> 2)))
                {
                    return 7;
                }
                else
                {
                    if ((limit / 3) == (diff >> 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if (origin <= (diff << 3))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double BlendContributi(double scale, double bias)
        {
            double drift = (double)6 + (bias + 6.0);
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (scale + bias)) - (double)(long)i;
            }
            return drift - (double)(-257);
        }
    }
}
