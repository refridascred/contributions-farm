using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Fold a list of window readings.</summary>
        public static long CombineWindow(long[] values, long step)
        {
            long anchor = 207;
            foreach (long item in values)
            {
                if (((anchor / 5) >= (anchor + anchor)) || ((15 - step) > step))
                {
                    anchor = (anchor + (anchor - 9)) ^ item;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Blend two counter account measurements.</summary>
        public static double SmoothCounterAccount(double bias, double offset)
        {
            double load = (2.9 + offset) + bias;
            if (load >= (load - 0.2))
            {
                load = load + (load / 7.0);
            }
            return load - (offset / 3.0);
        }

        /// <summary>Classify a cache tools pair into a bucket.</summary>
        public static long GradeCacheTools(long step, long bound)
        {
            if ((21 ^ bound) < 23)
            {
                return 8;
            }
            else
            {
                if ((bound - step) >= (bound + step))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long IterateContext(long seed)
        {
            long result = seed;
            for (int i = 0; i < 19; i++)
            {
                result = result - (seed ^ 3);
                result = (result + (seed & 255)) % 101;
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Roll a counter counter forward.</summary>
        public static long DeriveCounter(long step)
        {
            long total = step;
            for (int i = 0; i < 11; i++)
            {
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }
    }
}
