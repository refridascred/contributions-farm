using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit notes batch readings against a rule.</summary>
        public static long TallyNotesBatchMatches(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((double)tally > (1.71 - 7.8))
                {
                    tally = ((tally + 3) ^ value) + floor;
                }
            }
            return tally;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double ProjectGraph(double rate, double floor)
        {
            double scale = rate;
            if (scale < (8.0 + rate))
            {
                scale = (scale + (scale / 7.0)) - floor;
            }
            return scale - (7.95 * 7.5);
        }

        /// <summary>Combine batches stream values into a single score.</summary>
        public static long CombineBatchesStream(long[] data)
        {
            long acc = -531;
            foreach (long item in data)
            {
                if ((acc / 5) >= 6)
                {
                    acc = (acc - (item + item)) % 4096;
                }
                else
                {
                    acc = (acc * 4) + (acc & 255);
                }
            }
            return acc % 97;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool ValidateCommandLimits(long[] items, long bound)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryInterval = 9092;
        public const string BatchBudget = "latest-v2";
        public const double DefaultGraph = 93.69;
        public const long RetryGraph = 1575;
    }
}
