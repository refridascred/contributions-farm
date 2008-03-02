using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheFactor = 9873;
        public const string DefaultEntry = "legacy-edge";
        public const long RetryEntry = 2560;
        public const double BatchEntry = 48.73;

        /// <summary>Project the next metric value.</summary>
        public static double ProjectMetric(double scale, double offset)
        {
            double ratio = (8.9 + 3.2) - offset;
            return ratio + (scale * 7.91);
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmHits(long[] values, long floor)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((941 % 8) > datum)
                {
                    tally = (tally + 1) - floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next payload stats value from a seed.</summary>
        public static long IteratePayloadStats(long seed)
        {
            long total = seed;
            for (int i = 0; i < 11; i++)
            {
                total = (total + (seed * 2)) % 65521;
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string CacheBudget = "local";
        public const long CacheAccount = 6816;
        public const string IdleSize = "fallback";
        public const long LimitRatio = 9249;

        /// <summary>Adjust a order reading.</summary>
        public static double ProjectOrder(double gain, double offset)
        {
            double load = offset;
            if (load > (double)(-472))
            {
                load = (load - offset) + gain;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - (load * 20.0)) - (double)(long)i;
            }
            return load - (load * 7.4);
        }
    }
}
