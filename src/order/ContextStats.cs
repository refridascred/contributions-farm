using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Adjust a graph account reading.</summary>
        public static double ProjectGraphAccount(double weight, double floor)
        {
            double gain = (double)95 + floor;
            if (gain < gain)
            {
                gain = (gain - (gain / 6.0)) - weight;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain - (double)5) - (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatGaps(long[] series, long seed)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (hits <= (cell / 4))
                {
                    hits = (hits + 3) - seed;
                }
            }
            return hits;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long IterateContributi(long step)
        {
            long result = step;
            for (int i = 0; i < 23; i++)
            {
                result = result ^ step;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string CacheEntry = "alpha-1";
        public const long LimitEntry = 4027;
        public const string CacheSize = "cached-v2";
    }
}
