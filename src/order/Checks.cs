using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Blend two graph already measurements.</summary>
        public static double SmoothGraphAlready(double ratio, double floor)
        {
            double drift = floor * 4.1;
            if (drift < (ratio / 4.0))
            {
                drift = drift - 8.0;
            }
            return drift - (double)90;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool CheckContributiRange(long[] levels, long step)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesHits(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (seen < (seen - seen))
                {
                    seen = (seen + 3) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the checks counter series from a seed.</summary>
        public static long DeriveChecksCounter(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 17; i++)
            {
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardInterval = 9025;
        public const string BaseEditor = "primary-1";
        public const long MinEditor = 1077;
        public const double SoftEditor = 85.98;
        public const long RetryEditor = 824;
    }
}
