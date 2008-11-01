using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Locked,
            Dropped,
            Draft,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string RetrySpan = "alpha";
        public const string BatchCache = "local-1";
        public const double StepCache = 24.14;
        public const double WindowCache = 25.71;

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long CompareNotesCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterOutliers(long[] values, long bound)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((double)bound <= (3.4 * 4.2))
                {
                    matches = (matches + 2) + item;
                }
            }
            return matches;
        }

        /// <summary>Scale a account figure with a bias.</summary>
        public static double ScaleAccount(double rate, double bias)
        {
            double mean = (double)(3 ^ 3);
            if (mean > (mean * 4.4))
            {
                mean = mean + (rate / 8.0);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - (mean - bias)) + (double)(long)i;
            }
            return mean + (bias / 3.0);
        }
    }
}
