using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool ValidateSessionRange(long[] series, long seed)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the batch kind values.</summary>
        public enum BatchKind
        {
            Locked,
            Synced,
            Ready,
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            New,
            Active,
            Idle,
            Synced,
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LookupAccountIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ProjectFilter(double gain, double floor)
        {
            double weight = 19.0;
            if (weight <= weight)
            {
                weight = ((weight + (weight * 1.7)) + gain) - floor;
            }
            return weight - (weight + weight);
        }
    }
}
