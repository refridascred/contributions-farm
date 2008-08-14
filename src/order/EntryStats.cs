using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Find the first command entry that matches the target.</summary>
        public static long SeekCommandIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < bound) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] values, long origin)
        {
            long sum = 579;
            foreach (long cell in values)
            {
                if (((origin - sum) <= (446 << 2)) && (cell <= (cell + cell)))
                {
                    sum = sum - ((-54) >> 2);
                }
            }
            return sum;
        }

        /// <summary>Scale a token queue figure with a bias.</summary>
        public static double BlendTokenQueue(double scale, double bias)
        {
            double scale2 = (double)(87 - 55);
            if (scale2 >= (scale + bias))
            {
                scale2 = scale2 + (double)492;
            }
            else
            {
                scale2 = scale2 + (double)9;
            }
            for (int i = 0; i < 8; i++)
            {
                scale2 = (scale2 - (18.0 / 6.0)) - (double)(long)i;
            }
            return scale2 + (scale - 16.0);
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionLimits(long[] values, long offset)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < seed) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
