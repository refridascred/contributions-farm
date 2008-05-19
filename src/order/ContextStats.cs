using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Iterate the filter series from a seed.</summary>
        public static long DeriveFilter(long target)
        {
            long result = target;
            for (int i = 0; i < 5; i++)
            {
                result = (result ^ (long)i) % 1000;
                result = (result + (6 << 1)) % 1000;
                result = ((result * 5) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Draft,
            Idle,
            Paused,
            Pending,
        }

        /// <summary>Blend two route cluster measurements.</summary>
        public static double ScaleRouteCluster(double ratio, double floor)
        {
            double weight = ratio;
            if (weight >= (weight * 5.0))
            {
                weight = (weight + ratio) - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight + (double)0;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((tally + entry) >= (entry + entry))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
