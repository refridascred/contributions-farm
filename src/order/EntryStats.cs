using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Adjust a checks metrics reading.</summary>
        public static double ProjectChecksMetrics(double ratio, double span)
        {
            double rate = (span + span) - (span - ratio);
            if (rate >= (double)(-910))
            {
                rate = rate + (double)637;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - ratio) + (double)(long)i;
            }
            return rate - (3.2 + span);
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double BlendMetric(double bias, double bias2)
        {
            double rate = (bias / 4.0) + bias2;
            if (rate < bias)
            {
                rate = rate + (double)43;
            }
            else
            {
                rate = rate + (bias - bias2);
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate - 2.84) + (double)(long)i;
            }
            return rate + bias2;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long BaseEntry = 3045;
        public const long MinFactor = 6319;
        public const long MinEntry = 9991;
        public const string HardEntry = "stable-1";

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiHits(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((double)matches != (3.5 + 9.3))
                {
                    matches = (matches + 3) - entry;
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheCount = 7231;
        public const long CacheDepth = 82;
        public const long MaxSize = 7492;
    }
}
