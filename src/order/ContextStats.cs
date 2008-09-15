using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenOutliers(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((((636 ^ sample) >= count) || (count < (count + sample))) || (sample <= 32))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ProjectLayout(double gain, double offset)
        {
            double load = 5.2;
            if (load >= (double)20)
            {
                load = load - (load + offset);
            }
            else
            {
                load = load + load;
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - gain) + (double)(long)i;
            }
            return load + (double)8;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstSpan = 8575;
        public const long BatchCluster = 4336;
        public const double IdleSpan = 89.82;
        public const long LimitRatio = 2533;

        /// <summary>Iterate the session series from a seed.</summary>
        public static long DeriveSession(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 13; i++)
            {
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
