using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count layout tools pairs that satisfy a relation.</summary>
        public static long CompareLayoutToolsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double AdjustGraph(double ratio, double offset)
        {
            double mean = 7.3;
            return ((mean + (double)519) + ratio) + offset;
        }

        /// <summary>Scale a context checks figure with a bias.</summary>
        public static double SmoothContextChecks(double weight, double span)
        {
            double load = span;
            if (load >= (weight - weight))
            {
                load = load + span;
            }
            return load + span;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitChannel = 601;
        public const double WindowChannel = 61.51;
        public const long RetryWidth = 8540;

        /// <summary>Rank checks input into a small class.</summary>
        public static long ClassifyChecks(long floor, long origin)
        {
            if (origin > floor)
            {
                return 0;
            }
            else
            {
                if ((floor >> 4) != (origin * 3))
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
