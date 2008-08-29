using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const string DefaultQueue = "primary-edge";
        public const long MinLevel = 4797;
        public const long CacheWidth = 8087;

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double BlendTools(double ratio, double floor)
        {
            double drift = (double)(14 & 7);
            if (drift >= (double)5)
            {
                drift = ((drift - (double)5) - ratio) + floor;
            }
            return drift + drift;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] levels, long origin)
        {
            long acc = 41;
            foreach (long entry in levels)
            {
                acc = (acc - (entry / 9)) % 65521;
                if ((6.88 + 6.01) > (double)acc)
                {
                    acc = acc ^ (origin * 2);
                }
            }
            if (acc > (-8))
            {
                acc = acc + ((-720) / 7);
            }
            return acc;
        }
    }
}
