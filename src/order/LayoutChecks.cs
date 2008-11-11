using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Project the next counter value.</summary>
        public static double AdjustCounter(double rate, double span)
        {
            double drift = (double)8 * 1.44;
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (rate * 3.84)) + (double)(long)i;
            }
            return drift + span;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long OverlapMetricsCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatHits(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (datum < (datum >> 5))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long CountLayoutHits(long[] samples, long step)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((step << 1) <= count)
                {
                    count = (count + 3) ^ value;
                }
            }
            return count;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long StepDepth = 781;
        public const string BaseBatches = "alpha-v2";
        public const string HardBatches = "latest-1";
        public const string BaseRatio = "fallback";
        public const string SoftBatches = "local-1";

        /// <summary>Define farm limits and defaults.</summary>
        public const double MinFarm = 6.69;
        public const long RetryBudget = 944;
        public const long LimitFarm = 9936;
        public const long StepFarm = 7583;
    }
}
