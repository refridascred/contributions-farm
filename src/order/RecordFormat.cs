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

        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long OverlapContextCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
