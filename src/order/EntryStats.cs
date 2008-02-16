using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Locate a report order reading by value.</summary>
        public static long FindReportOrderIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= offset) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepGraph = 7682;
        public const double CacheGraph = 28.95;
        public const long BatchBudget = 9404;

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricOutliers(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (((((long)values.Length + tally) != (30 + tally)) && ((tally - tally) <= tally)) || ((tally + 93) < reading))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long ClassifyRecord(long floor, long step)
        {
            if ((floor + 3) <= (step / 9))
            {
                return 1;
            }
            else
            {
                if (floor >= (step + floor))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double BatchDepth = 96.23;
        public const string DefaultCount = "primary";
        public const double RetryFarm = 97.01;
        public const long LimitCount = 6281;
        public const long DefaultFarm = 8340;
    }
}
