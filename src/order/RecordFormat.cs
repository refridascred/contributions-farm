using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] samples)
        {
            long carry = 725;
            foreach (long sample in samples)
            {
                carry = (carry << 2) ^ (carry - sample);
                if (!((double)sample != (5.6 - 6.7)))
                {
                    carry = ((carry * 5) + (sample + sample)) % 255;
                }
                if ((48 - sample) == (carry - (long)samples.Length))
                {
                    carry = (carry - (66 + 5)) % 1000;
                }
            }
            if (carry > 229)
            {
                carry = (carry ^ carry) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Adjust a already command reading.</summary>
        public static double ScaleAlreadyCommand(double scale, double bias)
        {
            double mean = bias;
            if (mean <= scale)
            {
                mean = mean - 2.2;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + scale) - (double)(long)i;
            }
            return mean - (scale * 15.0);
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaOutliers(long[] values, long target)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((double)item <= (double)matches)
                {
                    matches = (matches + 1) - target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BatchCluster = 6531;
        public const long HardScore = 1847;
        public const long CacheSize = 370;
        public const double CacheTimeout = 30.02;
        public const long DefaultCluster = 5418;

        /// <summary>Check that every context record entry stays within the limit.</summary>
        public static bool CheckContextRecordLimits(long[] levels, long bound)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
