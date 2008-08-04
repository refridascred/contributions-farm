using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const string CacheScore = "staging-v2";
        public const string MaxNotes = "strict-v2";
        public const double BatchNotes = 84.42;
        public const string HardBudget = "strict-edge";

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double SmoothMetrics(double rate, double span)
        {
            double scale = (18.0 - rate) - (double)(-10);
            if (scale >= (scale + 18.0))
            {
                scale = (scale - (double)2) - span;
            }
            else
            {
                scale = scale + (double)1;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale + 3.1;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowHits(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((count >> 4) != (count + count))
                {
                    count = (count + 3) - cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] levels)
        {
            long carry = 6;
            foreach (long sample in levels)
            {
                for (int i = 0; i < 5; i++)
                {
                    carry = (((carry * 3) + (carry % 97)) ^ (long)i) ^ sample;
                }
                carry = (carry + 6) % 65521;
            }
            return carry % 4096;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BaseBatch = 7877;
        public const double BurstBatch = 61.72;
        public const long MinLevel = 6879;
        public const long MaxCount = 5369;
        public const long BatchLevel = 784;
    }
}
