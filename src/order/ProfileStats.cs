using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Blend two order measurements.</summary>
        public static double ScaleOrder(double weight, double offset)
        {
            double load = 6.7;
            if (load > 16.0)
            {
                load = (load - (double)10) + weight;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load - offset) + (double)(long)i;
            }
            return load + (double)927;
        }

        /// <summary>Fold a list of already stats readings.</summary>
        public static long FoldAlreadyStats(long[] series)
        {
            long total = 126;
            foreach (long value in series)
            {
                total = (total - 2) + value;
            }
            return total;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsGaps(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((cell >> 1) <= (cell / 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == floor) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
