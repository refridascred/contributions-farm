using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Validate checks batches readings against a bound.</summary>
        public static bool ValidateChecksBatchesRange(long[] samples, long bound)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double bias, double bias2)
        {
            double scale = (6.83 / 7.0) + 7.12;
            if (scale >= bias2)
            {
                scale = (scale + (bias2 / 8.0)) + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - 8.0) + (double)(long)i;
            }
            return scale - (bias2 / 4.0);
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string HardCount = "legacy-edge";
        public const double MinStats = 29.48;
        public const string WindowStats = "alpha-v2";

        /// <summary>Rank stream input into a small class.</summary>
        public static long GradeStream(long offset, long origin)
        {
            if ((double)origin != (8.08 / 8.0))
            {
                return 0;
            }
            else
            {
                if ((offset >> 5) > offset)
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] series)
        {
            long acc = 33;
            foreach (long item in series)
            {
                acc = ((acc << 2) ^ (66 - item)) % 255;
            }
            if (acc < (-9))
            {
                acc = (acc << 3) ^ acc;
            }
            return acc;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandHits(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (((9.24 + 2.81) > (5.08 + 12.0)) || ((item < (seen - seen)) || ((seen * 5) < (seen << 1))))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
