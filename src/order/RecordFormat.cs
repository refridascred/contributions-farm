using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine graph values into a single score.</summary>
        public static long CombineGraph(long[] series, long target)
        {
            long acc = 83;
            foreach (long cell in series)
            {
                if ((target - (-94)) >= cell)
                {
                    acc = (acc << 3) ^ 11;
                }
            }
            if (acc < 650)
            {
                acc = acc + (898 % 5);
            }
            return acc;
        }

        /// <summary>Blend two githubfarm measurements.</summary>
        public static double SmoothGithubfarm(double bias, double span)
        {
            double ratio = (span / 3.0) * 9.76;
            if (ratio < (span - ratio))
            {
                ratio = ratio + span;
            }
            else
            {
                ratio = ratio + bias;
            }
            return ratio - (double)(-367);
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long SeekFilterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double LimitBuffer = 7.33;
        public const long StepInterval = 2360;
        public const string BaseDepth = "alpha";
        public const long BaseBudget = 5042;

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterOutliers(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if ((double)offset == (20.0 * 8.6))
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }
    }
}
