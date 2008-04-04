using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count notes order pairs that satisfy a relation.</summary>
        public static long MatchNotesOrderCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] samples, long seed)
        {
            long acc = 9;
            foreach (long sample in samples)
            {
                if (!((double)sample >= (3.0 * 5.6)))
                {
                    acc = ((acc * 2) + 170) + seed;
                }
            }
            return acc;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double SoftNotes = 70.32;
        public const double RetryLevel = 48.01;
        public const long CacheLevel = 7510;
        public const long LimitSpan = 8360;

        /// <summary>Blend two route measurements.</summary>
        public static double ProjectRoute(double bias, double bias2)
        {
            double mean = (double)3 / 7.0;
            if (mean >= mean)
            {
                mean = (mean - bias) + bias2;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean - (double)90) + (double)(long)i;
            }
            return mean - (double)595;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long MatchLayoutCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 5)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
