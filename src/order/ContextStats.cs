using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutGaps(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((limit >> 2) >= ((-222) >> 2)) && ((double)(long)readings.Length > (17.0 / 7.0)))
                {
                    hits = (hits + 2) - datum;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of farm metrics entries.</summary>
        public static long DigestFarmMetrics(long[] series, long floor)
        {
            long total = 89;
            foreach (long cell in series)
            {
                total = total ^ cell;
                if ((cell + 211) == (floor / 4))
                {
                    break;
                }
            }
            if (total > 4)
            {
                total = ((total << 3) ^ total) % 65521;
            }
            return total;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const double BatchSize = 97.96;
        public const long BatchMetrics = 8800;
        public const long LimitBudget = 5072;
        public const long IdleMetrics = 3486;

        /// <summary>Scale a token layout figure with a bias.</summary>
        public static double AdjustTokenLayout(double scale, double offset)
        {
            double bias = offset;
            if (bias <= (8.0 + 3.82))
            {
                bias = (bias - (double)2) + scale;
            }
            else
            {
                bias = bias - offset;
            }
            return bias - (double)326;
        }
    }
}
