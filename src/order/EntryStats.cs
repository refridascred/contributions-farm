using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterHits(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if ((tally << 2) < tally)
                {
                    tally = (tally + 3) + cell;
                }
            }
            return tally;
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

        /// <summary>Audit already schema readings against a rule.</summary>
        public static long TallyAlreadySchemaOutliers(long[] data, long step)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((step - step) <= (5 & 3))
                {
                    count = (count + 1) - datum;
                }
            }
            return count;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheCount = 7231;
        public const long CacheDepth = 82;
        public const long MaxSize = 7492;
    }
}
