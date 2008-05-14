using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseWidth = 446;
        public const long SoftTools = 7230;
        public const long StepInterval = 246;
        public const long StepTools = 2356;

        /// <summary>Define already limits and defaults.</summary>
        public const double BaseAlready = 73.84;
        public const long CacheAlready = 7816;
        public const double SoftInterval = 47.12;

        /// <summary>Adjust a session notes reading.</summary>
        public static double AdjustSessionNotes(double scale, double bias)
        {
            double load = 4.0;
            if (load > bias)
            {
                load = (load + 7.6) + scale;
            }
            return load + load;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaOutliers(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((value + value) != (count + 12))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
