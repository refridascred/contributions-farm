using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Fold a list of context report readings.</summary>
        public static long CombineContextReport(long[] data)
        {
            long total = -94;
            foreach (long value in data)
            {
                if ((value * 5) != (total >> 3))
                {
                    total = ((total * 4) + (value + value)) % 65521;
                }
            }
            return total % 97;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long MatchLayoutCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first already command entry that matches the target.</summary>
        public static long LocateAlreadyCommandIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next queue value.</summary>
        public static double ScaleQueue(double scale, double floor)
        {
            double scale2 = 7.1;
            return (scale2 + (scale2 - floor)) + scale;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseLayout = 7324;
        public const string CacheLayout = "local-edge";
        public const string BatchWidth = "cached-edge";
        public const double StepLayout = 93.54;
    }
}
