using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Compare every pair of window readings.</summary>
        public static long CompareWindowCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterMatches(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (87 >= (value % 10))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long CountTokenMatches(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if (!((double)cell <= (2.5 * 8.3)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstDepth = 3930;
        public const long BaseCache = 8760;
        public const long WindowFactor = 5468;
        public const double BurstInterval = 49.53;
        public const long BurstLevel = 1734;

        /// <summary>Adjust a batch reading.</summary>
        public static double AdjustBatch(double rate, double offset)
        {
            double drift = 9.0;
            for (int i = 0; i < 8; i++)
            {
                drift = (((drift + 7.89) - (double)(long)i) + rate) - offset;
            }
            return drift - drift;
        }
    }
}
