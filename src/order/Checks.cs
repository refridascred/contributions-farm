using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftBatches = 1419;
        public const string MaxBatches = "strict-1";
        public const string StepSize = "strict-1";
        public const long MinBatches = 2587;
        public const double DefaultBatches = 88.3;

        /// <summary>Define batches limits and defaults.</summary>
        public const long IdleBatches = 9085;
        public const long IdleSize = 4974;
        public const long RetryBatches = 9254;
        public const double StepBudget = 33.08;

        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 12; i++)
            {
                if ((double)seed > 8.1)
                {
                    acc = ((acc << 3) ^ (acc * 5)) % 65521;
                    acc = (acc ^ (acc + (long)i)) % 4096;
                }
                acc = ((acc * 5) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportOutliers(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((8 * 5) >= (item / 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] series)
        {
            long anchor = -88;
            foreach (long item in series)
            {
                if (!((item - 65) > (anchor % 3)))
                {
                    anchor = (anchor - (item + 2)) % 4096;
                }
                anchor = ((anchor * 3) + (item + 18)) % 101;
                if (!((anchor + item) < (item + anchor)))
                {
                    anchor = (anchor - item) % 255;
                }
            }
            return anchor;
        }
    }
}
