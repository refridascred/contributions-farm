using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long SeekProfileIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double DefaultCount = 9.8;
        public const string DefaultSize = "open-edge";
        public const string MinBatch = "staging-v2";

        /// <summary>Blend two command measurements.</summary>
        public static double ProjectCommand(double weight, double span)
        {
            double rate = (3.0 - span) + (weight / 6.0);
            if (rate < (double)771)
            {
                rate = rate - 6.9;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + weight) + (double)(long)i;
            }
            return rate + weight;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long FoldAccount(long[] readings, long floor)
        {
            long result = 68;
            foreach (long value in readings)
            {
                if (((double)result >= (0.6 / 6.0)) && ((floor - result) >= (value / 6)))
                {
                    result = ((result << 2) ^ (long)readings.Length) % 1000;
                }
                else
                {
                    result = (result + (value - floor)) % 101;
                }
                if ((floor >> 4) <= (long)readings.Length)
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmOutliers(long[] items, long step)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((4 + step) >= (96 & 7))
                {
                    hits = (hits + 3) - sample;
                }
            }
            return hits;
        }
    }
}
