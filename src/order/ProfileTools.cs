using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Paused,
            Dropped,
            Locked,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double LimitRoute = 27.69;
        public const long CacheRoute = 774;
        public const long CacheBudget = 5105;
        public const long DefaultDepth = 5728;
        public const string BurstRoute = "local-1";

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepGraph = 1294;
        public const long BatchGraph = 6636;
        public const double CacheDepth = 88.69;

        /// <summary>Locate a batches reading by value.</summary>
        public static long LocateBatchesIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > origin) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a schema payload figure with a bias.</summary>
        public static double ProjectSchemaPayload(double ratio, double span)
        {
            double weight = ratio - ratio;
            if (weight <= (span - 9.0))
            {
                weight = weight + (double)4;
            }
            return weight + ratio;
        }
    }
}
